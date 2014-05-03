using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Yaffmi
{
	public partial class SettingsDialog : Form
	{
		public SettingsDialog()
		{
			InitializeComponent();

			ffmpegVersionBox.Items[0] =
				String.Format("Automatic ({0}-bit)", Settings.Architecture);
		}

		void SettingsDialog_Load(object sender, EventArgs e)
		{
			showAdvancedTabCheck.Checked = Settings.ShowAdvancedTab;
			showFullInputFilePathCheck.Checked = Settings.ShowFullInputFilePath;
			neverAbortOnErrorCheck.Checked = Settings.NeverAbortOnError;

			defaultOutputFolderBox.Text = Settings.DefaultOutputFolder;
			defaultSaveLogCheck.Checked = Settings.DefaultSaveLog;

			ffmpegPath32Box.Text = Settings.FFmpegPath32;
			ffmpegPath64Box.Text = Settings.FFmpegPath64;
			ffmpegVersionBox.SelectedIndex = Settings.FFmpegVersion / 32;
		}

		void SettingsDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				try
				{
					defaultOutputFolderBox.Text = defaultOutputFolderBox.Text
						.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
					if (defaultOutputFolderBox.Text.ContainsAny(Path.GetInvalidPathChars()) ||
						!Path.IsPathRooted(defaultOutputFolderBox.Text) ||
						!Directory.Exists(defaultOutputFolderBox.Text))
						throw new ControlValueException(defaultOutputFolderBox, "default output folder");

					if (ffmpegPath32Box.Text.ContainsAny(Path.GetInvalidPathChars()) ||
						!Path.IsPathRooted(ffmpegPath32Box.Text) ||
						!File.Exists(ffmpegPath32Box.Text))
						throw new ControlValueException(ffmpegPath32Box, "32-bit FFmpeg path");

					if (ffmpegPath64Box.Text.ContainsAny(Path.GetInvalidPathChars()) ||
						!Path.IsPathRooted(ffmpegPath64Box.Text) ||
						!File.Exists(ffmpegPath64Box.Text))
						throw new ControlValueException(ffmpegPath64Box, "64-bit FFmpeg path");
				}
				catch (ControlValueException ex)
				{
					ex.Focus();
					ex.ShowMessage(this);
					e.Cancel = true;
				}
			}
		}

		void SettingsDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				Settings.ShowAdvancedTab = showAdvancedTabCheck.Checked;
				Settings.ShowFullInputFilePath = showFullInputFilePathCheck.Checked;
				Settings.NeverAbortOnError = neverAbortOnErrorCheck.Checked;

				Settings.DefaultOutputFolder = defaultOutputFolderBox.Text;
				Settings.DefaultSaveLog = defaultSaveLogCheck.Checked;

				Settings.FFmpegPath32 = ffmpegPath32Box.Text;
				Settings.FFmpegPath64 = ffmpegPath64Box.Text;
				Settings.FFmpegVersion = ffmpegVersionBox.SelectedIndex * 32;

				Settings.Update();

				BackgroundWorker worker = new BackgroundWorker();

				worker.DoWork += (worker_sender, worker_e) => Settings.Save();

				worker.RunWorkerCompleted += (worker_sender, worker_e) =>
				{
					if (worker_e.Error != null)
					{
						if (worker_e.Error is SettingsException)
							MessageBox.Show(this,
								String.Format("Could not save \"{0}\".", Settings.SettingsFile),
								"Settings Save Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						else
							throw worker_e.Error;

						return;
					}
				};

				worker.RunWorkerAsync();
			}
		}

		void defaultOutputFolderBrowseButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog
			{
				Description = "Select an output folder:",
				SelectedPath = defaultOutputFolderBox.Text,
			};

			if (dialog.ShowDialog(this) == DialogResult.OK)
				defaultOutputFolderBox.Text = dialog.SelectedPath;
		}

		void ffmpegPath32BrowseButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Title = "Select 32-bit FFmpeg executable",
				Filter = "Windows executables|*.exe|All files|*",
			};
			try { dialog.InitialDirectory = Path.GetDirectoryName(ffmpegPath32Box.Text); }
			// This is just for convenience, let fail if it has to
			catch { }

			if (dialog.ShowDialog(this) == DialogResult.OK)
				ffmpegPath32Box.Text = dialog.FileName;
		}

		void ffmpegPath64BrowseButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Title = "Select 64-bit FFmpeg executable",
				Filter = "Windows executables|*.exe|All files|*",
			};
			try { dialog.InitialDirectory = Path.GetDirectoryName(ffmpegPath64Box.Text); }
			// This is just for convenience, let fail if it has to
			catch { }

			if (dialog.ShowDialog(this) == DialogResult.OK)
				ffmpegPath64Box.Text = dialog.FileName;
		}
	}
}
