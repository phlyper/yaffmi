namespace Yaffmi
{
	partial class SettingsDialog
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
			this.cancelButton = new System.Windows.Forms.Button();
			this.tabs = new System.Windows.Forms.TabControl();
			this.generalTab = new System.Windows.Forms.TabPage();
			this.neverAbortOnErrorCheck = new System.Windows.Forms.CheckBox();
			this.showFullInputFilePathCheck = new System.Windows.Forms.CheckBox();
			this.showAdvancedTabCheck = new System.Windows.Forms.CheckBox();
			this.outputTab = new System.Windows.Forms.TabPage();
			this.defaultSaveLogCheck = new System.Windows.Forms.CheckBox();
			this.defaultOutputFolderBrowseButton = new System.Windows.Forms.Button();
			this.defaultOutputFolderBox = new System.Windows.Forms.TextBox();
			this.defaultOutputFolderLabel = new System.Windows.Forms.Label();
			this.ffmpegTab = new System.Windows.Forms.TabPage();
			this.ffmpegVersionBox = new System.Windows.Forms.ComboBox();
			this.ffmpegVersionLabel = new System.Windows.Forms.Label();
			this.ffmpegPath64BrowseButton = new System.Windows.Forms.Button();
			this.ffmpegPath64Box = new System.Windows.Forms.TextBox();
			this.ffmpegPath64Label = new System.Windows.Forms.Label();
			this.ffmpegPath32BrowseButton = new System.Windows.Forms.Button();
			this.ffmpegPath32Box = new System.Windows.Forms.TextBox();
			this.ffmpegPath32Label = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.tabs.SuspendLayout();
			this.generalTab.SuspendLayout();
			this.outputTab.SuspendLayout();
			this.ffmpegTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(367, 400);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(85, 30);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.generalTab);
			this.tabs.Controls.Add(this.outputTab);
			this.tabs.Controls.Add(this.ffmpegTab);
			this.tabs.Location = new System.Drawing.Point(12, 12);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(440, 378);
			this.tabs.TabIndex = 0;
			// 
			// generalTab
			// 
			this.generalTab.Controls.Add(this.neverAbortOnErrorCheck);
			this.generalTab.Controls.Add(this.showFullInputFilePathCheck);
			this.generalTab.Controls.Add(this.showAdvancedTabCheck);
			this.generalTab.Location = new System.Drawing.Point(4, 25);
			this.generalTab.Name = "generalTab";
			this.generalTab.Padding = new System.Windows.Forms.Padding(3);
			this.generalTab.Size = new System.Drawing.Size(432, 349);
			this.generalTab.TabIndex = 0;
			this.generalTab.Text = "General";
			this.generalTab.UseVisualStyleBackColor = true;
			// 
			// neverAbortOnErrorCheck
			// 
			this.neverAbortOnErrorCheck.AutoSize = true;
			this.neverAbortOnErrorCheck.Location = new System.Drawing.Point(18, 67);
			this.neverAbortOnErrorCheck.Name = "neverAbortOnErrorCheck";
			this.neverAbortOnErrorCheck.Size = new System.Drawing.Size(192, 20);
			this.neverAbortOnErrorCheck.TabIndex = 2;
			this.neverAbortOnErrorCheck.Text = "Never abort processing on error";
			this.neverAbortOnErrorCheck.UseVisualStyleBackColor = true;
			// 
			// showFullInputFilePathCheck
			// 
			this.showFullInputFilePathCheck.AutoSize = true;
			this.showFullInputFilePathCheck.Location = new System.Drawing.Point(18, 41);
			this.showFullInputFilePathCheck.Name = "showFullInputFilePathCheck";
			this.showFullInputFilePathCheck.Size = new System.Drawing.Size(171, 20);
			this.showFullInputFilePathCheck.TabIndex = 1;
			this.showFullInputFilePathCheck.Text = "Show full path of input files";
			this.showFullInputFilePathCheck.UseVisualStyleBackColor = true;
			// 
			// showAdvancedTabCheck
			// 
			this.showAdvancedTabCheck.AutoSize = true;
			this.showAdvancedTabCheck.Location = new System.Drawing.Point(18, 15);
			this.showAdvancedTabCheck.Name = "showAdvancedTabCheck";
			this.showAdvancedTabCheck.Size = new System.Drawing.Size(217, 20);
			this.showAdvancedTabCheck.TabIndex = 0;
			this.showAdvancedTabCheck.Text = "Show advanced convert options tab";
			this.showAdvancedTabCheck.UseVisualStyleBackColor = true;
			// 
			// outputTab
			// 
			this.outputTab.Controls.Add(this.defaultSaveLogCheck);
			this.outputTab.Controls.Add(this.defaultOutputFolderBrowseButton);
			this.outputTab.Controls.Add(this.defaultOutputFolderBox);
			this.outputTab.Controls.Add(this.defaultOutputFolderLabel);
			this.outputTab.Location = new System.Drawing.Point(4, 25);
			this.outputTab.Name = "outputTab";
			this.outputTab.Padding = new System.Windows.Forms.Padding(3);
			this.outputTab.Size = new System.Drawing.Size(432, 349);
			this.outputTab.TabIndex = 1;
			this.outputTab.Text = "Output";
			this.outputTab.UseVisualStyleBackColor = true;
			// 
			// defaultSaveLogCheck
			// 
			this.defaultSaveLogCheck.AutoSize = true;
			this.defaultSaveLogCheck.Location = new System.Drawing.Point(18, 67);
			this.defaultSaveLogCheck.Name = "defaultSaveLogCheck";
			this.defaultSaveLogCheck.Size = new System.Drawing.Size(129, 20);
			this.defaultSaveLogCheck.TabIndex = 3;
			this.defaultSaveLogCheck.Text = "Save log by default";
			this.defaultSaveLogCheck.UseVisualStyleBackColor = true;
			// 
			// defaultOutputFolderBrowseButton
			// 
			this.defaultOutputFolderBrowseButton.Location = new System.Drawing.Point(325, 37);
			this.defaultOutputFolderBrowseButton.Name = "defaultOutputFolderBrowseButton";
			this.defaultOutputFolderBrowseButton.Size = new System.Drawing.Size(75, 26);
			this.defaultOutputFolderBrowseButton.TabIndex = 2;
			this.defaultOutputFolderBrowseButton.Text = "Browse...";
			this.defaultOutputFolderBrowseButton.UseVisualStyleBackColor = true;
			this.defaultOutputFolderBrowseButton.Click += new System.EventHandler(this.defaultOutputFolderBrowseButton_Click);
			// 
			// defaultOutputFolderBox
			// 
			this.defaultOutputFolderBox.Location = new System.Drawing.Point(18, 37);
			this.defaultOutputFolderBox.Name = "defaultOutputFolderBox";
			this.defaultOutputFolderBox.Size = new System.Drawing.Size(300, 20);
			this.defaultOutputFolderBox.TabIndex = 1;
			// 
			// defaultOutputFolderLabel
			// 
			this.defaultOutputFolderLabel.AutoSize = true;
			this.defaultOutputFolderLabel.Location = new System.Drawing.Point(15, 15);
			this.defaultOutputFolderLabel.Name = "defaultOutputFolderLabel";
			this.defaultOutputFolderLabel.Size = new System.Drawing.Size(122, 16);
			this.defaultOutputFolderLabel.TabIndex = 0;
			this.defaultOutputFolderLabel.Text = "Default output folder:";
			// 
			// ffmpegTab
			// 
			this.ffmpegTab.Controls.Add(this.ffmpegVersionBox);
			this.ffmpegTab.Controls.Add(this.ffmpegVersionLabel);
			this.ffmpegTab.Controls.Add(this.ffmpegPath64BrowseButton);
			this.ffmpegTab.Controls.Add(this.ffmpegPath64Box);
			this.ffmpegTab.Controls.Add(this.ffmpegPath64Label);
			this.ffmpegTab.Controls.Add(this.ffmpegPath32BrowseButton);
			this.ffmpegTab.Controls.Add(this.ffmpegPath32Box);
			this.ffmpegTab.Controls.Add(this.ffmpegPath32Label);
			this.ffmpegTab.Location = new System.Drawing.Point(4, 25);
			this.ffmpegTab.Name = "ffmpegTab";
			this.ffmpegTab.Size = new System.Drawing.Size(432, 349);
			this.ffmpegTab.TabIndex = 2;
			this.ffmpegTab.Text = "FFmpeg";
			this.ffmpegTab.UseVisualStyleBackColor = true;
			// 
			// ffmpegVersionBox
			// 
			this.ffmpegVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ffmpegVersionBox.FormattingEnabled = true;
			this.ffmpegVersionBox.Items.AddRange(new object[] {
            "Automatic",
            "32-Bit",
            "64-Bit"});
			this.ffmpegVersionBox.Location = new System.Drawing.Point(18, 143);
			this.ffmpegVersionBox.Name = "ffmpegVersionBox";
			this.ffmpegVersionBox.Size = new System.Drawing.Size(120, 24);
			this.ffmpegVersionBox.TabIndex = 7;
			// 
			// ffmpegVersionLabel
			// 
			this.ffmpegVersionLabel.AutoSize = true;
			this.ffmpegVersionLabel.Location = new System.Drawing.Point(15, 121);
			this.ffmpegVersionLabel.Name = "ffmpegVersionLabel";
			this.ffmpegVersionLabel.Size = new System.Drawing.Size(114, 16);
			this.ffmpegVersionLabel.TabIndex = 6;
			this.ffmpegVersionLabel.Text = "Use FFmpeg version:";
			// 
			// ffmpegPath64BrowseButton
			// 
			this.ffmpegPath64BrowseButton.Location = new System.Drawing.Point(325, 90);
			this.ffmpegPath64BrowseButton.Name = "ffmpegPath64BrowseButton";
			this.ffmpegPath64BrowseButton.Size = new System.Drawing.Size(75, 26);
			this.ffmpegPath64BrowseButton.TabIndex = 5;
			this.ffmpegPath64BrowseButton.Text = "Browse...";
			this.ffmpegPath64BrowseButton.UseVisualStyleBackColor = true;
			this.ffmpegPath64BrowseButton.Click += new System.EventHandler(this.ffmpegPath64BrowseButton_Click);
			// 
			// ffmpegPath64Box
			// 
			this.ffmpegPath64Box.Location = new System.Drawing.Point(18, 90);
			this.ffmpegPath64Box.Name = "ffmpegPath64Box";
			this.ffmpegPath64Box.Size = new System.Drawing.Size(300, 20);
			this.ffmpegPath64Box.TabIndex = 4;
			// 
			// ffmpegPath64Label
			// 
			this.ffmpegPath64Label.AutoSize = true;
			this.ffmpegPath64Label.Location = new System.Drawing.Point(15, 68);
			this.ffmpegPath64Label.Name = "ffmpegPath64Label";
			this.ffmpegPath64Label.Size = new System.Drawing.Size(113, 16);
			this.ffmpegPath64Label.TabIndex = 3;
			this.ffmpegPath64Label.Text = "64-bit FFmpeg path:";
			// 
			// ffmpegPath32BrowseButton
			// 
			this.ffmpegPath32BrowseButton.Location = new System.Drawing.Point(325, 37);
			this.ffmpegPath32BrowseButton.Name = "ffmpegPath32BrowseButton";
			this.ffmpegPath32BrowseButton.Size = new System.Drawing.Size(75, 26);
			this.ffmpegPath32BrowseButton.TabIndex = 2;
			this.ffmpegPath32BrowseButton.Text = "Browse...";
			this.ffmpegPath32BrowseButton.UseVisualStyleBackColor = true;
			this.ffmpegPath32BrowseButton.Click += new System.EventHandler(this.ffmpegPath32BrowseButton_Click);
			// 
			// ffmpegPath32Box
			// 
			this.ffmpegPath32Box.Location = new System.Drawing.Point(18, 37);
			this.ffmpegPath32Box.Name = "ffmpegPath32Box";
			this.ffmpegPath32Box.Size = new System.Drawing.Size(300, 20);
			this.ffmpegPath32Box.TabIndex = 1;
			// 
			// ffmpegPath32Label
			// 
			this.ffmpegPath32Label.AutoSize = true;
			this.ffmpegPath32Label.Location = new System.Drawing.Point(15, 15);
			this.ffmpegPath32Label.Name = "ffmpegPath32Label";
			this.ffmpegPath32Label.Size = new System.Drawing.Size(113, 16);
			this.ffmpegPath32Label.TabIndex = 0;
			this.ffmpegPath32Label.Text = "32-bit FFmpeg path:";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(276, 400);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(85, 30);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// SettingsDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(464, 442);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.cancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings - Yaffmi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsDialog_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsDialog_FormClosed);
			this.Load += new System.EventHandler(this.SettingsDialog_Load);
			this.tabs.ResumeLayout(false);
			this.generalTab.ResumeLayout(false);
			this.generalTab.PerformLayout();
			this.outputTab.ResumeLayout(false);
			this.outputTab.PerformLayout();
			this.ffmpegTab.ResumeLayout(false);
			this.ffmpegTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage generalTab;
		private System.Windows.Forms.TabPage outputTab;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TabPage ffmpegTab;
		private System.Windows.Forms.CheckBox neverAbortOnErrorCheck;
		private System.Windows.Forms.CheckBox showFullInputFilePathCheck;
		private System.Windows.Forms.CheckBox showAdvancedTabCheck;
		private System.Windows.Forms.Label defaultOutputFolderLabel;
		private System.Windows.Forms.Button defaultOutputFolderBrowseButton;
		private System.Windows.Forms.TextBox defaultOutputFolderBox;
		private System.Windows.Forms.CheckBox defaultSaveLogCheck;
		private System.Windows.Forms.Button ffmpegPath32BrowseButton;
		private System.Windows.Forms.TextBox ffmpegPath32Box;
		private System.Windows.Forms.Label ffmpegPath32Label;
		private System.Windows.Forms.Button ffmpegPath64BrowseButton;
		private System.Windows.Forms.TextBox ffmpegPath64Box;
		private System.Windows.Forms.Label ffmpegPath64Label;
		private System.Windows.Forms.ComboBox ffmpegVersionBox;
		private System.Windows.Forms.Label ffmpegVersionLabel;
	}
}