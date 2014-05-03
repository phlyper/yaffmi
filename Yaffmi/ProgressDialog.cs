using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Yaffmi
{
	public partial class ProgressDialog : Form
	{
		FormWindowState ownerPrevState;

		bool finished;
		int totalFiles;
		int currentFile;
		double currentFileProgress;

		public BackgroundWorker Worker { get; set; }
		public BackgroundWorker Argument { get; set; }

		public bool Finished
		{
			get { return finished; }

			set
			{
				finished = value;
				
				this.SetTaskbarProgressMode(
					(finished) ?
					TaskbarProgressMode.NoProgress :
					TaskbarProgressMode.Normal);

				cancelButton.Text =
					(finished) ?
					"Done" :
					"Cancel";
			}
		}

		public double TotalProgress
		{
			get
			{
				if (TotalFiles == 0)
					return 0;
				return Helpers.Clamp(
					(CurrentFile + CurrentFileProgress - 1) / TotalFiles,
					0, 1);
			}
		}

		public int TotalFiles
		{
			get { return totalFiles; }

			set
			{
				totalFiles = Helpers.ClampMin(value, 0);
				UpdateTotalProgress();
			}
		}

		public int CurrentFile
		{
			get { return currentFile; }

			set
			{
				currentFile = Helpers.ClampMin(value, 0);
				UpdateTotalProgress();
			}
		}

		public double CurrentFileProgress
		{
			get { return currentFileProgress; }

			set
			{
				currentFileProgress = Helpers.Clamp(value, 0, 1);
				UpdateCurrentFileProgress();
			}
		}

		public ProgressDialog()
		{
			InitializeComponent();

			ownerPrevState = FormWindowState.Normal;

			Finished = false;
			TotalFiles = 1;
			CurrentFile = 1;
			CurrentFileProgress = 0;

			Worker = null;
			Argument = null;
		}

		void ProgressDialog_Load(object sender, EventArgs e)
		{
			if (!Finished &&
				Worker != null &&
				!Worker.IsBusy)
				Worker.RunWorkerAsync(Argument);
		}

		void ProgressDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!Finished &&
				Worker != null &&
				Worker.WorkerSupportsCancellation)
				Worker.CancelAsync();
		}

		void ProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel =
				!Finished &&
				MessageBox.Show(this,
				"Are you sure you want to cancel the current operation?",
				"Confirm Cancel",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.No;
		}

		void ProgressDialog_Resize(object sender, EventArgs e)
		{
			if (Owner != null)
			{
				if (WindowState == FormWindowState.Minimized &&
					Owner.WindowState != FormWindowState.Minimized)
				{
					ownerPrevState = Owner.WindowState;
					Owner.WindowState = FormWindowState.Minimized;
					// This keeps Windows from killing our dialog
					Visible = true;
				}
				else if (WindowState != FormWindowState.Minimized &&
					Owner.WindowState == FormWindowState.Minimized)
					Owner.WindowState = ownerPrevState;
			}
		}

		void UpdateTotalProgress()
		{
			Text = String.Format(
				"Converting [{0:F0}%] - Yaffmi",
				TotalProgress * 100);

			totalProgressLabel.Text = String.Format(
				"Total progress: [{0:F0}%]",
				TotalProgress * 100);

			totalProgressBar.Value =
				(int)Math.Round(TotalProgress * 1000);

			if (!Finished)
				this.SetTaskbarProgress(
					1000,
					(int)Math.Round(TotalProgress * 1000));
		}

		void UpdateCurrentFileProgress()
		{
			currentFileLabel.Text = String.Format(
				"File {0} of {1}: [{2:F0}%]",
				CurrentFile, TotalFiles,
				CurrentFileProgress * 100);

			currentFileBar.Value =
				(int)Math.Round(CurrentFileProgress * 1000);

			UpdateTotalProgress();
		}
	}
}
