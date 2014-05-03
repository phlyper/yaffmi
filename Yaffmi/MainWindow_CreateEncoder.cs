using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yaffmi
{
	partial class MainWindow
	{
		FFmpegEncoder CreateEncoder()
		{
			FFmpegEncoder encoder = new FFmpegEncoder(Settings.FFmpegPath);

			try
			{
				encoder.FileFormat = fileFormatBox.Text;
				// Must be letters, numbers, and underscores only
				if (!Regex.IsMatch(encoder.FileFormat, @"^\w*$"))
					throw new ControlValueException(fileFormatBox, "file format");

				encoder.FilenameExtension = fileExtBox.Text
					.TrimStart('.');
				if (encoder.FilenameExtension.ContainsAny(Path.GetInvalidFileNameChars()))
					throw new ControlValueException(fileExtBox, "file name extension");

				encoder.OutputFolder = outputFolderBox.Text
					.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
				if (encoder.OutputFolder.ContainsAny(Path.GetInvalidPathChars()) ||
					!Path.IsPathRooted(encoder.OutputFolder) ||
					!Directory.Exists(encoder.OutputFolder))
					throw new ControlValueException(outputFolderBox, "output folder");

				encoder.IncludeVideo = includeVideoCheck.Checked;
				if (encoder.IncludeVideo)
				{
					if (!String.IsNullOrEmpty(videoStreamsBox.Text))
					{
						encoder.VideoStreams = videoStreamsBox.Text
							.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
							.Select(index =>
							{
								int i;
								if (!Int32.TryParse(index, out i) ||
									i < 0)
									throw new ControlValueException(videoStreamsBox, "video streams list");
								return i;
							})
							.ToArray();
					}

					encoder.VideoCodec = videoCodecBox.Text;
					// Must be letters, numbers, and underscores only
					if (!Regex.IsMatch(encoder.VideoCodec, @"^\w*$"))
						throw new ControlValueException(videoCodecBox, "video codec");

					if (!String.IsNullOrEmpty(widthBox.Text))
					{
						int width;
						if (!Int32.TryParse(widthBox.Text, out width) ||
							width <= 0)
							throw new ControlValueException(widthBox, "video width");
						encoder.Width = width;
					}

					if (!String.IsNullOrEmpty(heightBox.Text))
					{
						int height;
						if (!Int32.TryParse(heightBox.Text, out height) ||
							height <= 0)
							throw new ControlValueException(heightBox, "video height");
						encoder.Height = height;
					}

					if (!String.IsNullOrEmpty(videoBitrateBox.Text))
					{
						double bitrate;
						if (!Double.TryParse(videoBitrateBox.Text, out bitrate) ||
							bitrate <= 0)
							throw new ControlValueException(videoBitrateBox, "video bitrate");
						encoder.VideoBitrate = bitrate;
					}

					if (!String.IsNullOrEmpty(darBox.Text))
					{
						var e = new ControlValueException(darBox, "display aspect ratio");
						string[] parts = darBox.Text.Split(":/\\".ToCharArray(), 2);
						double numerator;
						if (!Double.TryParse(parts[0], out numerator))
							throw e;
						encoder.DisplayAspectRatio = numerator;
						if (parts.Length > 1)
						{
							double denominator;
							if (!Double.TryParse(parts[1], out denominator) ||
								denominator == 0)
								throw e;
							encoder.DisplayAspectRatio /= denominator;
						}
						if (encoder.DisplayAspectRatio <= 0)
							throw e;
					}

					if (!String.IsNullOrEmpty(frameRateBox.Text))
					{
						double frameRate;
						if (!Double.TryParse(frameRateBox.Text, out frameRate) ||
							frameRate <= 0)
							throw new ControlValueException(frameRateBox, "frame rate");
						encoder.FrameRate = frameRate;
					}

					if (!String.IsNullOrEmpty(topBox.Text))
					{
						int top;
						if (!Int32.TryParse(topBox.Text, out top) ||
							top < 0)
							throw new ControlValueException(topBox, "top crop margin");
						encoder.CropTop = top;
					}

					if (!String.IsNullOrEmpty(leftBox.Text))
					{
						int left;
						if (!Int32.TryParse(leftBox.Text, out left) ||
							left < 0)
							throw new ControlValueException(leftBox, "left crop margin");
						encoder.CropLeft = left;
					}

					if (!String.IsNullOrEmpty(rightBox.Text))
					{
						int right;
						if (!Int32.TryParse(rightBox.Text, out right) ||
							right < 0)
							throw new ControlValueException(rightBox, "right crop margin");
						encoder.CropRight = right;
					}

					if (!String.IsNullOrEmpty(bottomBox.Text))
					{
						int bottom;
						if (!Int32.TryParse(bottomBox.Text, out bottom) ||
							bottom < 0)
							throw new ControlValueException(bottomBox, "bottom crop margin");
						encoder.CropBottom = bottom;
					}

					encoder.VideoFilters = videoFiltersBox.Text;
				}

				encoder.IncludeAudio = includeAudioCheck.Checked;
				if (encoder.IncludeAudio)
				{
					if (!String.IsNullOrEmpty(audioStreamsBox.Text))
					{
						encoder.AudioStreams = audioStreamsBox.Text
							.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
							.Select(index =>
							{
								int i;
								if (!Int32.TryParse(index, out i) ||
									i < 0)
									throw new ControlValueException(audioStreamsBox, "audio streams list");
								return i;
							})
							.ToArray();
					}

					encoder.AudioCodec = audioCodecBox.Text;
					// Must be letters, numbers, and underscores only
					if (!Regex.IsMatch(encoder.AudioCodec, @"^\w*$"))
						throw new ControlValueException(audioCodecBox, "audio codec");

					if (!String.IsNullOrEmpty(audioBitrateBox.Text))
					{
						double bitrate;
						if (!Double.TryParse(audioBitrateBox.Text, out bitrate) ||
							bitrate <= 0)
							throw new ControlValueException(audioBitrateBox, "audio bitrate");
						encoder.AudioBitrate = bitrate;
					}

					if (!String.IsNullOrEmpty(channelCountBox.Text))
					{
						int channelCount;
						if (!Int32.TryParse(channelCountBox.Text, out channelCount) ||
							channelCount <= 0)
							throw new ControlValueException(channelCountBox, "channel count");
						encoder.ChannelCount = channelCount;
					}

					if (!String.IsNullOrEmpty(sampleRateBox.Text))
					{
						double sampleRate;
						if (!Double.TryParse(sampleRateBox.Text, out sampleRate) ||
							sampleRate <= 0)
							throw new ControlValueException(sampleRateBox, "sample rate");
						encoder.SampleRate = sampleRate;
					}

					if (!String.IsNullOrEmpty(volumeBox.Text))
					{
						double volume;
						if (!Double.TryParse(volumeBox.Text, out volume) ||
							volume < 0 ||
							// LAME will violently crash if volume is increased too much
							// Someone should probbably report that
							volume > 10000000)
							throw new ControlValueException(volumeBox, "volume");
						encoder.Volume = volume / 100;
					}

					encoder.AudioFilters = audioFiltersBox.Text;
				}

				encoder.IncludeSubtitles = includeSubtitlesCheck.Checked;
				if (encoder.IncludeSubtitles &&
					!String.IsNullOrEmpty(subtitlesStreamsBox.Text))
				{
					encoder.SubtitlesStreams = subtitlesStreamsBox.Text
						.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
						.Select(index =>
						{
							int i;
							if (!Int32.TryParse(index, out i) ||
								i < 0)
								throw new ControlValueException(subtitlesStreamsBox, "subtitles streams list");
							return i;
						})
						.ToArray();
				}

				encoder.GlobalParams = globalParamsBox.Text;
				encoder.InputParams = inputParamsBox.Text;
				encoder.OutputParams = outputParamsBox.Text;
			}
			catch (ControlValueException e)
			{
				e.Focus();
				e.ShowMessage(this);

				return null;
			}

			return encoder;
		}
	}
}
