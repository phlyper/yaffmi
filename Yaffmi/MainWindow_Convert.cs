using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Yaffmi
{
	partial class MainWindow
	{
		class ConvertProgress
		{
			public int FileCtr { get; private set; }
			public double FileProgress { get; private set; }

			public ConvertProgress(int fileCtr, double fileProgress)
			{
				FileCtr = fileCtr;
				FileProgress = fileProgress;
			}
		}

		void convertButton_Click(object sender, EventArgs e)
		{
			BeginConvert();
		}

		void BeginConvert()
		{
			FFmpegEncoder encoder = CreateEncoder();
			if (encoder == null)
				return;

			if (fileListBox.Items.Count <= 0)
			{
				MessageBox.Show(this,
					"The list of files to convert is empty.",
					"No Files",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			InputFile[] files = fileListBox.Items
				.OfType<InputFile>()
				.ToArray();

			bool saveLog = saveLogCheck.Checked;

			BackgroundWorker worker = new BackgroundWorker
			{
				WorkerReportsProgress = true, 
				WorkerSupportsCancellation = true,
			};

			ProgressDialog progressDialog = new ProgressDialog
			{
				TotalFiles = files.Length, 
				Worker = worker,
			};

			Log log = new Log();
			Log errorLog = new Log();

			string error = null;
			bool critical = false;
			bool runErrors = false;

			worker.DoWork += (sender, e) =>
			{
				DateTime startTime = DateTime.Now;

				if (saveLog)
				{
					log.OpenFile(String.Format(
						"{0}{1}Yaffmi Log {2:yyyy'.'MM'.'dd HH'.'mm'.'ss}.txt",
						encoder.OutputFolder, Path.DirectorySeparatorChar, startTime));

					if (!log.FileIsOpen)
					{
						error = String.Format("Could not save \"{0}\".", log.FilePath);
						critical = true;
						return;
					}
				}

				log.WriteLine(Settings.Title);
				log.WriteLine("Start time: {0:G}", startTime);
				log.WriteLine("FFmpeg path: {0}", encoder.FFmpegPath);
				log.WriteLine("Output directory: {0}", encoder.OutputFolder);
				log.WriteLine();

				int fileCtr = 0;
				foreach (InputFile file in files)
				{
					DateTime fileStartTime = DateTime.Now;

					int tempFileCtr = fileCtr;

					log.WriteLine("Item {0} of {1}", tempFileCtr + 1, files.Length);
					log.WriteLine("Item start time: {0:G}", fileStartTime);

					FFmpegOperation operation = encoder.BeginEncode(file.FilePath);
					
					log.WriteLine("Input file: {0}", operation.InputFilePath);
					log.WriteLine("Output file: {0}", operation.OutputFilePath);
					log.WriteLine("Command: \"{0}\" {1}", operation.FFmpegPath, operation.Arguments);

					if (operation.Status != FFmpegOperationStatus.ProcessStartError)
					{
						operation.ProgressChanged += (operation_sender, operation_e) =>
							worker.ReportProgress(0, new ConvertProgress(tempFileCtr,
								// Don't let it hit 100% until we are done
								(operation.Progress < 0.994) ? operation.Progress : 0.994));

						operation.BeginStatusReporting();

						// This seems kind of ugly, but BackgroundWorker doesn't expose any other method of
						// detecting cancelations besides polling CancellationPending
						while (true)
						{
							if (worker.CancellationPending)
							{
								operation.Cancel();
								operation.WaitForFinish();
								break;
							}
							
							if (operation.WaitForFinish(15))
								break;
						}
					}

					DateTime fileEndTime = DateTime.Now;

					foreach (string line in operation.Log)
						log.WriteLine("> {0}", line);
					log.WriteLine("Result: {0}", operation.Status);
					log.WriteLine("Item end time: {0:G}", fileEndTime);
					log.WriteLine();

					if (worker.CancellationPending)
						break;

					// If the first file fails before processing starts, don't try to keep going
					if (!Settings.NeverAbortOnError &&
						tempFileCtr == 0 &&
						(operation.Status == FFmpegOperationStatus.ProcessStartError ||
						operation.Status == FFmpegOperationStatus.InitializationError))
					{
						error = operation.Error;
						critical = operation.Status == FFmpegOperationStatus.ProcessStartError;
						break;
					}

					// If something fails later on, log it and continue
					if (operation.Status != FFmpegOperationStatus.Success)
					{
						// If we don't have a log file yet, create an error log
						if (!log.FileIsOpen &&
							!errorLog.FileIsOpen)
						{
							errorLog.OpenFile(String.Format(
								"{0}{1}Yaffmi Errors {2:yyyy'.'MM'.'dd HH'.'mm'.'ss}.txt",
								encoder.OutputFolder, Path.DirectorySeparatorChar, startTime));

							errorLog.WriteLine(Settings.Title);
							errorLog.WriteLine("Error log");
							errorLog.WriteLine();
						}

						errorLog.WriteLine("Item {0} of {1}", tempFileCtr + 1, files.Length);
						errorLog.WriteLine("Input file: {0}", operation.InputFilePath);
						errorLog.WriteLine("Error: {0}", operation.Error);
						errorLog.WriteLine();

						runErrors = true;
					}

					worker.ReportProgress(0, new ConvertProgress(tempFileCtr, 1));

					fileCtr++;
				}

				DateTime endTime = DateTime.Now;

				errorLog.CloseFile();

				log.WriteLine("Yaffmi finished.");
				log.WriteLine("End time: {0:G}", endTime);
				log.CloseFile();
				
			};

			worker.ProgressChanged += (sender, e) =>
			{
				ConvertProgress progress = (ConvertProgress)e.UserState;
				progressDialog.CurrentFile = progress.FileCtr + 1;
				progressDialog.CurrentFileProgress = progress.FileProgress;
			};

			worker.RunWorkerCompleted += (sender, e) =>
			{
				progressDialog.Finished = true;

				if (error != null)
				{
					progressDialog.Close();
					MessageBox.Show(this,
						error, "Convert Error",
						MessageBoxButtons.OK, 
						(critical) ? MessageBoxIcon.Error : MessageBoxIcon.Warning);
					return;
				}

				if (runErrors)
				{
					if ((errorLog.FilePath != null && errorLog.GetLastError(false) == null) ||
						(log.FilePath != null && log.GetLastError(false) == null))
					MessageBox.Show(this,
						String.Format(
							"One or more files were not converted successfully. See \"{0}\" in the output folder for more information.",
							Path.GetFileName(errorLog.FilePath ?? log.FilePath)),
						"Convert Errors",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						MessageBox.Show(this,
						"One or more files were not converted successfully. There was a problem creating files in the output folder.",
						"Convert Errors",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			};

			progressDialog.ShowDialog(this);
		}
	}
}
