using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Yaffmi
{
	partial class MainWindow
	{
		class PresetItem
		{
			public string FilePath { get; private set; }
			public string Name { get; private set; }
			public bool BuiltIn { get; private set; }

			public PresetItem(string filePath, bool builtIn)
			{
				FilePath = filePath;
				Name = Path.GetFileNameWithoutExtension(filePath);
				BuiltIn = builtIn;
			}

			public override string ToString()
			{
				return Name;
			}
		}

		bool unsavedChanges;

		// Store previous value in Tag property to use if we need to revert the selection
		// Works because SelectionChangeCommitted is called before SelectedIndexChanged
		void presetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			presetBox.Tag = presetBox.SelectedIndex;
		}

		void presetBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (!BeginLoadPreset(true))
				presetBox.SelectedIndex = (int)presetBox.Tag;
		}

		void reloadButton_Click(object sender, EventArgs e)
		{
			BeginLoadPreset(true);
		}

		void saveButton_Click(object sender, EventArgs e)
		{
			BeginSavePreset(((PresetItem)presetBox.SelectedItem).Name);
		}

		void saveAsButton_Click(object sender, EventArgs e)
		{
			SavePresetDialog dialog = new SavePresetDialog
			{
				PresetName = (presetBox.SelectedItem != null) ?
					((PresetItem)presetBox.SelectedItem).Name : "",
			};

			while (true)
			{
				if (dialog.ShowDialog(this) != DialogResult.OK)
					break;
				dialog.PresetName = dialog.PresetName.Trim();

				if (BeginSavePreset(dialog.PresetName))
					break;
			}
		}

		void deleteButton_Click(object sender, EventArgs e)
		{
			BeginDeletePreset();
		}

		void OptionValueChanged(object sender, EventArgs e)
		{
			statusLabel.Text = "Modified.";
			unsavedChanges = true;
		}

		void BeginUpdatePresets()
		{
			PresetItem[] globalPresets = null;
			PresetItem[] userPresets = null;

			string error = null;

			BackgroundWorker worker = new BackgroundWorker();

			worker.DoWork += (sender, e) =>
			{
				try
				{
					globalPresets =
						Directory.GetFiles(Settings.GlobalPresetsDirectory)
						.Select(path => new PresetItem(path, true))
						.ToArray();
				}
				catch
				{
					error = String.Format(
						"Could not load presets from \"{0}\".", 
						Settings.GlobalPresetsDirectory);
				}

				try
				{
					userPresets =
						Directory.GetFiles(Settings.UserPresetsDirectory)
						.Select(path => new PresetItem(path, false))
						.ToArray();
				}
				catch
				{
					error = String.Format(
						"Could not load presets from \"{0}\".",
						Settings.UserPresetsDirectory);
				}
			};

			worker.RunWorkerCompleted += (sender, e) =>
			{
				presetBox.BeginUpdate();
				presetBox.Items.Clear();
				if (globalPresets != null)
					presetBox.Items.AddRange(globalPresets);
				if (userPresets != null)
					presetBox.Items.AddRange(userPresets);
				if (presetBox.Items.Count > 0)
					presetBox.SelectedIndex = 0;
				presetBox.EndUpdate();

				if (error != null)
					MessageBox.Show(this,
						error, "Preset Load Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);

				BeginLoadPreset(false);
			};

			worker.RunWorkerAsync();
		}

		void BeginDeletePreset()
		{
			PresetItem preset = (PresetItem)presetBox.SelectedItem;
			if (preset == null ||
				preset.BuiltIn)
				return;

			if (MessageBox.Show(this,
					String.Format("Are you sure you want to delete the preset named \"{0}\"?", preset.Name),
					"Confirm Delete Preset",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
				!= DialogResult.OK)
				return;

			BackgroundWorker worker = new BackgroundWorker();

			worker.DoWork += (sender, e) => 
				File.Delete(preset.FilePath);

			worker.RunWorkerCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					MessageBox.Show(this,
						String.Format("Could not delete \"{0}\".", preset.FilePath),
						"Preset Delete Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				int oldIndex = presetBox.SelectedIndex;
				presetBox.BeginUpdate();
				presetBox.Items.Remove(preset);
				presetBox.SelectedIndex = Math.Min(oldIndex, presetBox.Items.Count - 1);
				presetBox.EndUpdate();

				BeginLoadPreset(false);
			};

			worker.RunWorkerAsync();
		}
	}
}
