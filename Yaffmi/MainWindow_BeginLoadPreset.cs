using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace Yaffmi
{
	partial class MainWindow
	{
		bool BeginLoadPreset(bool prompt)
		{
			PresetItem preset = (PresetItem)presetBox.SelectedItem;
			if (preset == null)
				return false;

			if (prompt &&
				unsavedChanges &&
				MessageBox.Show(this,
					"Loading a preset will overwrite your current options. Continue?",
					"Confirm Load Preset",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
				!= DialogResult.OK)
				return false;

			saveButton.Enabled = !preset.BuiltIn;
			deleteButton.Enabled = !preset.BuiltIn;

			statusLabel.Text = "Loading...";

			XmlDocument document = new XmlDocument();

			BackgroundWorker worker = new BackgroundWorker();

			worker.DoWork += (sender, e) => document.Load(preset.FilePath);

			worker.RunWorkerCompleted += (sender, e) =>
			{
				if (e.Error != null ||
				    document.DocumentElement == null)
				{
					statusLabel.Text = "Load error.";
					unsavedChanges = false;

					MessageBox.Show(this,
						String.Format("Could not load \"{0}\".", preset.FilePath),
						"Preset Load Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}

				XmlElement presetElement = document.DocumentElement;

				globalParamsBox.Text = presetElement.GetChildText("GlobalParams") ?? "";
				inputParamsBox.Text = presetElement.GetChildText("InputParams") ?? "";
				outputParamsBox.Text = presetElement.GetChildText("OutputParams") ?? "";

				fileFormatBox.Text = presetElement.GetChildText("FileFormat") ?? "";
				fileExtBox.Text = presetElement.GetChildText("FilenameExtension") ?? "";

				includeVideoCheck.Checked = Helpers.ToBool(presetElement.GetChildText("IncludeVideo"));
				videoStreamsBox.Text = presetElement.GetChildText("VideoStreams") ?? "";
				videoCodecBox.Text = presetElement.GetChildText("VideoCodec") ?? "";
				widthBox.Text = presetElement.GetChildText("Width") ?? "";
				heightBox.Text = presetElement.GetChildText("Height") ?? "";
				videoBitrateBox.Text = presetElement.GetChildText("VideoBitrate") ?? "";
				darBox.Text = presetElement.GetChildText("DisplayAspectRatio") ?? "";
				frameRateBox.Text = presetElement.GetChildText("FrameRate") ?? "";
				topBox.Text = presetElement.GetChildText("CropTop") ?? "";
				leftBox.Text = presetElement.GetChildText("CropLeft") ?? "";
				rightBox.Text = presetElement.GetChildText("CropRight") ?? "";
				bottomBox.Text = presetElement.GetChildText("CropBottom") ?? "";
				videoFiltersBox.Text = presetElement.GetChildText("VideoFilters") ?? "";

				includeAudioCheck.Checked = Helpers.ToBool(presetElement.GetChildText("IncludeAudio"));
				audioStreamsBox.Text = presetElement.GetChildText("AudioStreams") ?? "";
				audioCodecBox.Text = presetElement.GetChildText("AudioCodec") ?? "";
				audioBitrateBox.Text = presetElement.GetChildText("AudioBitrate") ?? "";
				channelCountBox.Text = presetElement.GetChildText("ChannelCount") ?? "";
				sampleRateBox.Text = presetElement.GetChildText("SampleRate") ?? "";
				volumeBox.Text = presetElement.GetChildText("Volume") ?? "";
				audioFiltersBox.Text = presetElement.GetChildText("AudioFilters") ?? "";

				includeSubtitlesCheck.Checked = Helpers.ToBool(presetElement.GetChildText("IncludeSubtitles"));
				subtitlesStreamsBox.Text = presetElement.GetChildText("SubtitlesStreams") ?? "";

				statusLabel.Text = "";
				unsavedChanges = false;
			};

			worker.RunWorkerAsync();

			return true;
		}
	}
}
