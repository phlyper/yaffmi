using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Yaffmi
{
	enum FFmpegOperationStatus
	{
		Initializing,
		Running,
		Success,
		ProcessStartError,
		InitializationError,
		RunError,
		Canceled,
	}

	class FFmpegOperation
	{
		bool success;
		bool canceled;

		readonly ManualResetEvent finished = new ManualResetEvent(false);

		readonly List<string> log;
		int lastIndentLine;
		int lastProgressLine;

		public Process Worker { get; private set; }
		public Exception WorkerStartException { get; private set; }
		public string FFmpegPath { get; private set; }
		public string Arguments { get; private set; }
		public string InputFilePath { get; private set; }
		public string OutputFilePath { get; private set; }

		public FFmpegOperationStatus Status { get; private set; }
		public string Error { get; private set; }

		public double TotalLength { get; private set; } // seconds
		public double CurrentLength { get; private set; } // seconds

		public event EventHandler StatusChanged;
		public event EventHandler ProgressChanged;

		public double Progress // 1 = 100%
		{
			get
			{
				if (TotalLength == 0)
					return 0;
				return Helpers.Clamp(
					CurrentLength / TotalLength,
					0, 1);
			}
		}

		public ReadOnlyCollection<string> Log { get { return log.AsReadOnly(); } }

		public static FFmpegOperation Begin(
			string ffmpegPath, string arguments, 
			string inputFile = null, string outputFile = null)
		{
			Process worker = new Process
			{
				StartInfo =
				{
					FileName = ffmpegPath,
					Arguments = arguments,
					UseShellExecute = false,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true
				}
			};

			Exception workerStartException = null;
			try { worker.Start(); }
			catch (Exception e) { workerStartException = e; }

			FFmpegOperation ffmpegOperation = 
				new FFmpegOperation(worker, workerStartException)
			{
				InputFilePath = inputFile, 
				OutputFilePath = outputFile,
			};

			return ffmpegOperation;
		}

		public FFmpegOperation(Process worker, Exception workerStartException = null)
		{
			success = false;
			canceled = false;

			log = new List<string>();
			lastIndentLine = -1;
			lastProgressLine = -1;

			Worker = worker;
			WorkerStartException = workerStartException;
			FFmpegPath = worker.StartInfo.FileName;
			Arguments = worker.StartInfo.Arguments;

			TotalLength = 0;
			CurrentLength = 0;

			if (workerStartException == null)
			{
				finished = new ManualResetEvent(false);

				Status = FFmpegOperationStatus.Initializing;
				Error = null;

				// FFmpeg sends all of its output to STDERR
				worker.ErrorDataReceived += Worker_ErrorDataReceived;
			}
			else
			{
				finished = new ManualResetEvent(true);

				Status = FFmpegOperationStatus.ProcessStartError;
				Error = (FFmpegPath != null) ? 
					String.Format("Could not start \"{0}\".", FFmpegPath) :
					"Could not start FFmpeg.";
			}
		}

		// Parsing the FFmpeg output involves a lot of ugly heuristics
		// Anyone who wants to exhaustively check the FFmpeg source to make sure these will always 
		// work is welcome to do so. :)
		void Worker_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			string line = e.Data;

			// We get a null line when the process exits
			if (line == null)
			{
				if (success)
					Status = FFmpegOperationStatus.Success;
				else if (canceled)
					Status = FFmpegOperationStatus.Canceled;
				else
				{
					int lastNonErrorLine;

					if (Status == FFmpegOperationStatus.Running)
					{
						Status = FFmpegOperationStatus.RunError;
						lastNonErrorLine = lastProgressLine;
					}
					else
					{
						Status = FFmpegOperationStatus.InitializationError;
						lastNonErrorLine = lastIndentLine;
					}

					StringBuilder error = new StringBuilder();
					for (int i = lastNonErrorLine + 1; i < log.Count; i++)
					{
						// Remove bracketed text from beginning
						string errorLine = Regex.Replace(log[i], @"^\[[^\[\]]*\]", "");

						// Condense multiple consecutive spaces to one
						errorLine = Regex.Replace(errorLine, @" {2,}", " ");

						errorLine = errorLine.Trim();

						// Don't bother saying it's an invalid argument if we already have other (usually better) info
						if (error.Length > 0 &&
							Regex.IsMatch(errorLine, @": Invalid argument$"))
							errorLine = "";
						
						if (errorLine.Length > 0)
							error.AppendLine(errorLine);
					}

					Error = error.ToString().TrimEnd('\r', '\n');
				}

				if (StatusChanged != null)
					StatusChanged(this, EventArgs.Empty);

				finished.Set();

				return;
			}

			log.Add(line);

			// Try to find the total length of the stream
			if (Status == FFmpegOperationStatus.Initializing &&
				TotalLength == 0)
			{
				Match match = Regex.Match(line, @"^  Duration: ([^ ,]+), ");
				if (match.Success)
				{
					TimeSpan time;
					if (TimeSpan.TryParse(match.Groups[1].Value, out time))
						TotalLength = time.TotalSeconds;

					return;
				}
			}

			// Lines indented with at least 2 sapces usually occur right before processing begins
			if (Status == FFmpegOperationStatus.Initializing &&
				Regex.IsMatch(line, @"^ {2,}[^ ]"))
				lastIndentLine = log.Count - 1;

			// Get the current progress
			if ((Status == FFmpegOperationStatus.Initializing ||
				Status == FFmpegOperationStatus.Running) &&
				Regex.IsMatch(line, @"^([a-zA-Z0-9]+= *[^ ]+( +|$))+$"))
			{
				if (Status == FFmpegOperationStatus.Initializing)
				{
					Status = FFmpegOperationStatus.Running;
					if (StatusChanged != null)
						StatusChanged(this, EventArgs.Empty);
				}

				lastProgressLine = log.Count - 1;

				string timeStr =
					Regex.Matches(line, @"([a-zA-Z0-9]+)= *([^ ]+)(?: |$)")
					.Cast<Match>()
					.Where(match => match.Groups[1].Value == "time")
					.Select(match => match.Groups[2].Value)
					.FirstOrDefault();

				TimeSpan time;
				if (TimeSpan.TryParse(timeStr, out time))
				{
					CurrentLength = time.TotalSeconds;
					if (ProgressChanged != null)
						ProgressChanged(this, EventArgs.Empty);
				}

				return;
			}

			// Yaay, it worked!
			if ((Status == FFmpegOperationStatus.Initializing ||
				Status == FFmpegOperationStatus.Running) &&
				Regex.IsMatch(line, @"^video:[^ ]* audio:[^ ]*( subtitle:[^ ]*)?( data:[^ ]*)? global headers:[^ ]* muxing overhead [^ ]*$"))
				success = true;
		}

		public void BeginStatusReporting()
		{
			Worker.BeginErrorReadLine();
		}

		public void PauseStatusReporting()
		{
			Worker.CancelErrorRead();
		}

		public bool WaitForFinish(int timeout = -1)
		{
			return finished.WaitOne(timeout);
		}

		public void Cancel()
		{
			canceled = true;
			Worker.Kill();
		}
	}
}
