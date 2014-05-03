namespace Yaffmi
{
	partial class ProgressDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.currentFileBar = new System.Windows.Forms.ProgressBar();
			this.currentFileLabel = new System.Windows.Forms.Label();
			this.totalProgressLabel = new System.Windows.Forms.Label();
			this.totalProgressBar = new System.Windows.Forms.ProgressBar();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// currentFileBar
			// 
			this.currentFileBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentFileBar.Location = new System.Drawing.Point(15, 34);
			this.currentFileBar.Maximum = 1000;
			this.currentFileBar.Name = "currentFileBar";
			this.currentFileBar.Size = new System.Drawing.Size(524, 21);
			this.currentFileBar.Step = 1;
			this.currentFileBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.currentFileBar.TabIndex = 1;
			// 
			// currentFileLabel
			// 
			this.currentFileLabel.AutoSize = true;
			this.currentFileLabel.Location = new System.Drawing.Point(12, 12);
			this.currentFileLabel.Name = "currentFileLabel";
			this.currentFileLabel.Size = new System.Drawing.Size(87, 16);
			this.currentFileLabel.TabIndex = 0;
			this.currentFileLabel.Text = "File X of Y: [J%]";
			// 
			// totalProgressLabel
			// 
			this.totalProgressLabel.AutoSize = true;
			this.totalProgressLabel.Location = new System.Drawing.Point(12, 66);
			this.totalProgressLabel.Name = "totalProgressLabel";
			this.totalProgressLabel.Size = new System.Drawing.Size(112, 16);
			this.totalProgressLabel.TabIndex = 2;
			this.totalProgressLabel.Text = "Total progress: [K%]";
			// 
			// totalProgressBar
			// 
			this.totalProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.totalProgressBar.Location = new System.Drawing.Point(15, 88);
			this.totalProgressBar.Maximum = 1000;
			this.totalProgressBar.Name = "totalProgressBar";
			this.totalProgressBar.Size = new System.Drawing.Size(524, 21);
			this.totalProgressBar.Step = 1;
			this.totalProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.totalProgressBar.TabIndex = 3;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(454, 127);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(85, 30);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// ProgressDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(554, 172);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.totalProgressLabel);
			this.Controls.Add(this.totalProgressBar);
			this.Controls.Add(this.currentFileLabel);
			this.Controls.Add(this.currentFileBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ProgressDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Converting [K%] - Yaffmi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressDialog_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgressDialog_FormClosed);
			this.Load += new System.EventHandler(this.ProgressDialog_Load);
			this.Resize += new System.EventHandler(this.ProgressDialog_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar currentFileBar;
		private System.Windows.Forms.Label currentFileLabel;
		private System.Windows.Forms.Label totalProgressLabel;
		private System.Windows.Forms.ProgressBar totalProgressBar;
		private System.Windows.Forms.Button cancelButton;
	}
}