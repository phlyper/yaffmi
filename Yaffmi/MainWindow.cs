using System;
using System.Windows.Forms;

namespace Yaffmi
{
	partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();

			includeVideoCheck.CheckedChanged += OptionValueChanged;
			includeAudioCheck.CheckedChanged += OptionValueChanged;
			includeSubtitlesCheck.CheckedChanged += OptionValueChanged;

			unsavedChanges = false;
		}

		void MainWindow_Load(object sender, EventArgs e)
		{
			BeginUpdatePresets();

			Config_Updated(this, EventArgs.Empty);
			Settings.Updated += Config_Updated;
		}

		void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Updated -= Config_Updated;
		}

		void Config_Updated(object sender, EventArgs e)
		{
			if (!Settings.ShowAdvancedTab &&
				optionsTabs.TabPages.Contains(advancedTab))
				optionsTabs.TabPages.Remove(advancedTab);
			else if (Settings.ShowAdvancedTab &&
				!optionsTabs.TabPages.Contains(advancedTab))
				optionsTabs.TabPages.Add(advancedTab);

			fileListBox.RefreshItems();

			outputFolderBox.Text = Settings.DefaultOutputFolder;
			saveLogCheck.Checked = Settings.DefaultSaveLog;
		}

		void includeVideoCheck_CheckedChanged(object sender, EventArgs e)
		{
			videoStreamsLabel.Enabled = includeVideoCheck.Checked;
			videoStreamsBox.Enabled = includeVideoCheck.Checked;
			videoTab.Enabled = includeVideoCheck.Checked;
			videoFiltersBox.Enabled = includeVideoCheck.Checked;
		}

		void includeAudioCheck_CheckedChanged(object sender, EventArgs e)
		{
			audioStreamsLabel.Enabled = includeAudioCheck.Checked;
			audioStreamsBox.Enabled = includeAudioCheck.Checked;
			audioTab.Enabled = includeAudioCheck.Checked;
			audioFiltersBox.Enabled = includeAudioCheck.Checked;
		}

		void includeSubtitlesCheck_CheckedChanged(object sender, EventArgs e)
		{
			subtitlesStreamsLabel.Enabled = includeSubtitlesCheck.Checked;
			subtitlesStreamsBox.Enabled = includeSubtitlesCheck.Checked;
		}

		void browseButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog
			{
				Description = "Select an output folder:",
			};

			if (dialog.ShowDialog(this) == DialogResult.OK)
				outputFolderBox.Text = dialog.SelectedPath;
		}

		void settingsButton_Click(object sender, EventArgs e)
		{
			SettingsDialog settings = new SettingsDialog();
			settings.ShowDialog(this);
		}

		void aboutButton_Click(object sender, EventArgs e)
		{
			AboutDialog about = new AboutDialog();
			about.ShowDialog(this);
		}
	}
}
