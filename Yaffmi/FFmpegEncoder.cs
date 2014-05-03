using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Yaffmi
{
	class FFmpegEncoder
	{
		public string FFmpegPath { get; set; }

		public string GlobalParams { get; set; }
		public string InputParams { get; set; }
		public string OutputParams { get; set; }

		public string FileFormat { get; set; }
		public string FilenameExtension { get; set; }

		public bool IncludeVideo { get; set; }
		public int[] VideoStreams { get; set; }
		public string VideoCodec { get; set; }
		public int Width { get; set; } // pixels
		public int Height { get; set; } // pixels
		public double VideoBitrate { get; set; } // kbits/sec
		public double DisplayAspectRatio { get; set; }
		public double FrameRate { get; set; } // frames/sec
		public int CropTop { get; set; } // pixels
		public int CropLeft { get; set; } // pixels
		public int CropRight { get; set; } // pixels
		public int CropBottom { get; set; } // pixels
		public string VideoFilters { get; set; }

		public bool IncludeAudio { get; set; }
		public int[] AudioStreams { get; set; }
		public string AudioCodec { get; set; }
		public double AudioBitrate { get; set; } // kbits/sec
		public int ChannelCount { get; set; }
		public double SampleRate { get; set; } // samples/sec
		public double Volume { get; set; } // 1 = 100%
		public string AudioFilters { get; set; }

		public bool IncludeSubtitles { get; set; }
		public int[] SubtitlesStreams { get; set; }

		public string OutputFolder { get; set; }

		public FFmpegEncoder(string ffmpegPath)
		{
			FFmpegPath = ffmpegPath;

			GlobalParams = "";
			InputParams = "";
			OutputParams = "";

			FileFormat = "";
			FilenameExtension = "";

			IncludeVideo = false;
			VideoStreams = new int[] { };
			VideoCodec = "";
			Width = -1;
			Height = -1;
			VideoBitrate = -1;
			DisplayAspectRatio = -1;
			FrameRate = -1;
			CropTop = -1;
			CropLeft = -1;
			CropRight = -1;
			CropBottom = -1;
			VideoFilters = "";

			IncludeAudio = false;
			AudioStreams = new int[] { };
			AudioCodec = "";
			AudioBitrate = -1;
			ChannelCount = -1;
			SampleRate = -1;
			Volume = -1;
			AudioFilters = "";

			IncludeSubtitles = false;
			SubtitlesStreams = new int[] { };

			OutputFolder = "";
		}

		public string GetArguments(string inputFile, string outputFile)
		{
			StringBuilder arguments = new StringBuilder();

			// Global parameters

			arguments.Append("-hide_banner -loglevel repeat+info -nostdin -y ");

			if (!String.IsNullOrWhiteSpace(GlobalParams))
				arguments.AppendFormat("{0} ", GlobalParams);

			// Input parameters

			if (!String.IsNullOrWhiteSpace(InputParams))
				arguments.AppendFormat("{0} ", InputParams);

			arguments.AppendFormat("-i \"{0}\" ", inputFile);

			// Output parameters

			if (!String.IsNullOrWhiteSpace(FileFormat))
				arguments.AppendFormat("-f {0} ", FileFormat);

			if (IncludeVideo)
			{
				if (VideoStreams != null &&
					VideoStreams.Length > 0)
				{
					foreach (int index in VideoStreams)
						arguments.AppendFormat(
							CultureInfo.InvariantCulture, 
							"-map 0:v:{0} ", index);
				}
				else
					// Include all of them
					arguments.Append("-map 0:v ");

				bool doCrop = CropTop >= 0 || CropLeft >= 0 || CropRight >= 0 || CropBottom >= 0;
				bool doUserFilters = !String.IsNullOrWhiteSpace(VideoFilters);

				if (doCrop || doUserFilters)
				{
					arguments.Append("-filter:v ");

					if (doCrop)
						arguments.AppendFormat(
							CultureInfo.InvariantCulture,
							"crop=in_w-{1}-{2}:in_h-{0}-{3}:{1}:{0},",
							(CropTop < 0) ? 0 : CropTop,
							(CropLeft < 0) ? 0 : CropLeft,
							(CropRight < 0) ? 0 : CropRight,
							(CropBottom < 0) ? 0 : CropBottom);

					if (doUserFilters)
						arguments.AppendFormat("{0},", VideoFilters);

					// Remove trailing ','
					arguments.Length--;

					arguments.Append(" ");
				}

				if (!String.IsNullOrWhiteSpace(VideoCodec))
					arguments.AppendFormat("-c:v {0} ", VideoCodec);

				if (Width >= 0 && Height >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-s:v {0}x{1} ", Width, Height);

				if (VideoBitrate >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-b:v {0:F0} ", VideoBitrate * 1000);

				if (DisplayAspectRatio >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-aspect:v {0:F4} ", DisplayAspectRatio);

				if (FrameRate >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-r:v {0:F3} ", FrameRate);
			}
			else
				arguments.Append("-vn ");

			if (IncludeAudio)
			{
				if (AudioStreams != null &&
					AudioStreams.Length > 0)
				{
					foreach (int index in AudioStreams)
						arguments.AppendFormat(
							CultureInfo.InvariantCulture,
							"-map 0:a:{0} ", index);
				}
				else
					// Include all of them
					arguments.Append("-map 0:a ");

				bool doUserFilters = !String.IsNullOrWhiteSpace(AudioFilters);
				bool doVolume = Volume >= 0;

				if (doUserFilters || doVolume)
				{
					arguments.Append("-filter:a ");

					if (doUserFilters)
						arguments.AppendFormat("{0},", AudioFilters);

					if (doVolume)
						arguments.AppendFormat(
							CultureInfo.InvariantCulture,
							"volume={0:F4},", Volume);

					// Remove trailing ','
					arguments.Length--;

					arguments.Append(" ");
				}

				if (!String.IsNullOrWhiteSpace(AudioCodec))
					arguments.AppendFormat("-c:a {0} ", AudioCodec);

				if (AudioBitrate >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-b:a {0:F0} ", AudioBitrate * 1000);

				if (ChannelCount >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-ac:a {0} ", ChannelCount);

				if (SampleRate >= 0)
					arguments.AppendFormat(
						CultureInfo.InvariantCulture,
						"-ar:a {0:F0} ", SampleRate);
			}
			else
				arguments.Append("-an ");

			if (IncludeSubtitles)
			{
				if (SubtitlesStreams != null &&
					SubtitlesStreams.Length > 0)
				{
					foreach (int index in SubtitlesStreams)
						arguments.AppendFormat(
							CultureInfo.InvariantCulture,
							"-map 0:s:{0} ", index);
				}
				else
					// Include all of them
					arguments.Append("-map 0:s ");

				// Don't try to re-encode subtitles
				arguments.Append("-c:s copy ");
			}
			else
				arguments.Append("-sn ");

			// We don't support data streams
			arguments.Append("-dn ");

			if (!String.IsNullOrWhiteSpace(OutputParams))
				arguments.AppendFormat("{0} ", OutputParams);

			arguments.AppendFormat("\"{0}\"", outputFile);

			return arguments.ToString();
		}

		public string GetArguments(string inputFile)
		{
			return GetArguments(inputFile, GetOutputFilePath(inputFile));
		}

		public string GetOutputFilePath(string inputFile)
		{
			string outputFile =
				OutputFolder +
				Path.DirectorySeparatorChar +
				Path.GetFileNameWithoutExtension(inputFile);
			if (!String.IsNullOrEmpty(FilenameExtension))
				outputFile += "." + FilenameExtension;

			return outputFile;
		}

		public FFmpegOperation BeginEncode(string inputFile, string outputFile)
		{
			return FFmpegOperation.Begin(
				FFmpegPath, 
				GetArguments(inputFile, outputFile),
				inputFile, outputFile);
		}

		public FFmpegOperation BeginEncode(string inputFile)
		{
			string outputFile = GetOutputFilePath(inputFile);
			return BeginEncode(inputFile, outputFile);
		}
	}
}
