using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Yaffmi
{
	partial class MainWindow
	{
		bool BeginSavePreset(string name)
		{
			if (String.IsNullOrWhiteSpace(name) ||
				name.ContainsAny(Path.GetInvalidFileNameChars()))
			{
				MessageBox.Show(this,
					"The preset name is not valid.",
					"Invalid Preset Name",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			PresetItem[] nameConflicts = presetBox.Items
				.OfType<PresetItem>()
				.Where(item => String.Equals(item.Name, name, StringComparison.OrdinalIgnoreCase))
				.ToArray();

			if (nameConflicts.Any(item => item.BuiltIn))
			{
				MessageBox.Show(this,
					"The preset name is already in use by a built-in preset.",
					"Invalid Preset Name",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (nameConflicts.Any() &&
				MessageBox.Show(this,
					String.Format(
						"Are you sure you want to overwrite the existing preset named \"{0}\"?",
						nameConflicts[0].Name),
					"Confirm Overwrite Preset",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
				!= DialogResult.OK)
				return false;

			statusLabel.Text = "Saving...";

			PresetItem preset = new PresetItem(
				Settings.UserPresetsDirectory +
				Path.DirectorySeparatorChar +
				name + ".xml",
				false);

			XmlDocument document = new XmlDocument();
			XmlElement presetElement = document.AppendNewChildElement("YaffmiPreset");

			presetElement.AppendNewChildElement("GlobalParams", globalParamsBox.Text);
			presetElement.AppendNewChildElement("InputParams", inputParamsBox.Text);
			presetElement.AppendNewChildElement("OutputParams", outputParamsBox.Text);

			presetElement.AppendNewChildElement("FileFormat", fileFormatBox.Text);
			presetElement.AppendNewChildElement("FilenameExtension", fileExtBox.Text);

			presetElement.AppendNewChildElement("IncludeVideo",
				includeVideoCheck.Checked.ToString().ToLower());
			if (includeVideoCheck.Checked)
			{
				presetElement.AppendNewChildElement("VideoStreams", videoStreamsBox.Text);
				presetElement.AppendNewChildElement("VideoCodec", videoCodecBox.Text);
				presetElement.AppendNewChildElement("Width", widthBox.Text);
				presetElement.AppendNewChildElement("Height", heightBox.Text);
				presetElement.AppendNewChildElement("VideoBitrate", videoBitrateBox.Text);
				presetElement.AppendNewChildElement("DisplayAspectRatio", darBox.Text);
				presetElement.AppendNewChildElement("FrameRate", frameRateBox.Text);
				presetElement.AppendNewChildElement("CropTop", topBox.Text);
				presetElement.AppendNewChildElement("CropLeft", leftBox.Text);
				presetElement.AppendNewChildElement("CropRight", rightBox.Text);
				presetElement.AppendNewChildElement("CropBottom", bottomBox.Text);
				presetElement.AppendNewChildElement("VideoFilters", videoFiltersBox.Text);
			}

			presetElement.AppendNewChildElement("IncludeAudio",
				includeAudioCheck.Checked.ToString().ToLower());
			if (includeAudioCheck.Checked)
			{
				presetElement.AppendNewChildElement("AudioStreams", audioStreamsBox.Text);
				presetElement.AppendNewChildElement("AudioCodec", audioCodecBox.Text);
				presetElement.AppendNewChildElement("AudioBitrate", audioBitrateBox.Text);
				presetElement.AppendNewChildElement("ChannelCount", channelCountBox.Text);
				presetElement.AppendNewChildElement("SampleRate", sampleRateBox.Text);
				presetElement.AppendNewChildElement("Volume", volumeBox.Text);
				presetElement.AppendNewChildElement("AudioFilters", audioFiltersBox.Text);
			}

			presetElement.AppendNewChildElement("IncludeSubtitles",
				includeSubtitlesCheck.Checked.ToString().ToLower());
			if (includeSubtitlesCheck.Checked)
				presetElement.AppendNewChildElement("SubtitlesStreams", subtitlesStreamsBox.Text);

			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true, 
				CloseOutput = true,
			};

			BackgroundWorker worker = new BackgroundWorker();

			worker.DoWork += (sender, e) =>
			{
				foreach (PresetItem item in nameConflicts)
					File.Delete(item.FilePath);

				using (XmlWriter writer = XmlWriter.Create(preset.FilePath, settings))
					document.WriteTo(writer);
			};

			worker.RunWorkerCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					statusLabel.Text = "Save error.";

					MessageBox.Show(this,
						String.Format("Could not save \"{0}\".", preset.FilePath),
						"Preset Save Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}

				presetBox.BeginUpdate();
				foreach (PresetItem item in nameConflicts)
					presetBox.Items.Remove(item);
				presetBox.Items.Add(preset);
				presetBox.SelectedItem = preset;
				presetBox.EndUpdate();

				statusLabel.Text = "";
				unsavedChanges = false;
			};

			worker.RunWorkerAsync();

			return true;
		}
	}
}
