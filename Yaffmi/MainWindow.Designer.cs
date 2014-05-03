namespace Yaffmi
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.fileListBox = new System.Windows.Forms.ListBox();
			this.optionsTabs = new System.Windows.Forms.TabControl();
			this.presetTab = new System.Windows.Forms.TabPage();
			this.statusLabel = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.saveAsButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.reloadButton = new System.Windows.Forms.Button();
			this.presetBox = new System.Windows.Forms.ComboBox();
			this.presetLabel = new System.Windows.Forms.Label();
			this.outputTab = new System.Windows.Forms.TabPage();
			this.saveLogCheck = new System.Windows.Forms.CheckBox();
			this.subtitlesStreamsLabel = new System.Windows.Forms.Label();
			this.audioStreamsLabel = new System.Windows.Forms.Label();
			this.videoStreamsLabel = new System.Windows.Forms.Label();
			this.subtitlesStreamsBox = new System.Windows.Forms.TextBox();
			this.includeSubtitlesCheck = new System.Windows.Forms.CheckBox();
			this.audioStreamsBox = new System.Windows.Forms.TextBox();
			this.videoStreamsBox = new System.Windows.Forms.TextBox();
			this.fileExtBox = new System.Windows.Forms.TextBox();
			this.fileExtLabel = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.outputFolderLabel = new System.Windows.Forms.Label();
			this.outputFolderBox = new System.Windows.Forms.TextBox();
			this.includeAudioCheck = new System.Windows.Forms.CheckBox();
			this.includeVideoCheck = new System.Windows.Forms.CheckBox();
			this.fileFormatBox = new System.Windows.Forms.TextBox();
			this.fileFormatLabel = new System.Windows.Forms.Label();
			this.videoTab = new System.Windows.Forms.TabPage();
			this.fpsLabel = new System.Windows.Forms.Label();
			this.videoKbpsLabel = new System.Windows.Forms.Label();
			this.pixelsLabel = new System.Windows.Forms.Label();
			this.videoCodecBox = new System.Windows.Forms.TextBox();
			this.videoCodecLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rightLabel = new System.Windows.Forms.Label();
			this.rightBox = new System.Windows.Forms.TextBox();
			this.bottomLabel = new System.Windows.Forms.Label();
			this.bottomBox = new System.Windows.Forms.TextBox();
			this.leftLabel = new System.Windows.Forms.Label();
			this.leftBox = new System.Windows.Forms.TextBox();
			this.topLabel = new System.Windows.Forms.Label();
			this.topBox = new System.Windows.Forms.TextBox();
			this.videoBitrateBox = new System.Windows.Forms.TextBox();
			this.videoBitrateLabel = new System.Windows.Forms.Label();
			this.frameRateBox = new System.Windows.Forms.TextBox();
			this.frameRateLabel = new System.Windows.Forms.Label();
			this.darBox = new System.Windows.Forms.TextBox();
			this.darLabel = new System.Windows.Forms.Label();
			this.xLabel = new System.Windows.Forms.Label();
			this.heightBox = new System.Windows.Forms.TextBox();
			this.widthBox = new System.Windows.Forms.TextBox();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.audioTab = new System.Windows.Forms.TabPage();
			this.percentLabel = new System.Windows.Forms.Label();
			this.volumeBox = new System.Windows.Forms.TextBox();
			this.volumeLabel = new System.Windows.Forms.Label();
			this.hzLabel = new System.Windows.Forms.Label();
			this.audioKbpsLabel = new System.Windows.Forms.Label();
			this.audioCodecBox = new System.Windows.Forms.TextBox();
			this.audioCodecLabel = new System.Windows.Forms.Label();
			this.sampleRateBox = new System.Windows.Forms.TextBox();
			this.sampleRateLabel = new System.Windows.Forms.Label();
			this.channelCountBox = new System.Windows.Forms.TextBox();
			this.channelCountLabel = new System.Windows.Forms.Label();
			this.audioBitrateBox = new System.Windows.Forms.TextBox();
			this.audioBitrateLabel = new System.Windows.Forms.Label();
			this.advancedTab = new System.Windows.Forms.TabPage();
			this.videoFiltersBox = new System.Windows.Forms.TextBox();
			this.videoFiltersLabel = new System.Windows.Forms.Label();
			this.inputParamsBox = new System.Windows.Forms.TextBox();
			this.inputParamsLabel = new System.Windows.Forms.Label();
			this.outputParamsBox = new System.Windows.Forms.TextBox();
			this.outputParamsLabel = new System.Windows.Forms.Label();
			this.audioFiltersBox = new System.Windows.Forms.TextBox();
			this.audioFiltersLabel = new System.Windows.Forms.Label();
			this.globalParamsBox = new System.Windows.Forms.TextBox();
			this.globalParamsLabel = new System.Windows.Forms.Label();
			this.aboutButton = new System.Windows.Forms.Button();
			this.settingsButton = new System.Windows.Forms.Button();
			this.convertButton = new System.Windows.Forms.Button();
			this.clearListButton = new System.Windows.Forms.Button();
			this.removeItemButton = new System.Windows.Forms.Button();
			this.addItemButton = new System.Windows.Forms.Button();
			this.optionsTabs.SuspendLayout();
			this.presetTab.SuspendLayout();
			this.outputTab.SuspendLayout();
			this.videoTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.audioTab.SuspendLayout();
			this.advancedTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileListBox
			// 
			this.fileListBox.AllowDrop = true;
			this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileListBox.FormattingEnabled = true;
			this.fileListBox.IntegralHeight = false;
			this.fileListBox.ItemHeight = 16;
			this.fileListBox.Location = new System.Drawing.Point(12, 80);
			this.fileListBox.Name = "fileListBox";
			this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.fileListBox.Size = new System.Drawing.Size(760, 245);
			this.fileListBox.TabIndex = 6;
			this.fileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileListBox_DragDrop);
			this.fileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileListBox_DragEnter);
			// 
			// optionsTabs
			// 
			this.optionsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.optionsTabs.Controls.Add(this.presetTab);
			this.optionsTabs.Controls.Add(this.outputTab);
			this.optionsTabs.Controls.Add(this.videoTab);
			this.optionsTabs.Controls.Add(this.audioTab);
			this.optionsTabs.Controls.Add(this.advancedTab);
			this.optionsTabs.Location = new System.Drawing.Point(12, 333);
			this.optionsTabs.Name = "optionsTabs";
			this.optionsTabs.SelectedIndex = 0;
			this.optionsTabs.Size = new System.Drawing.Size(760, 317);
			this.optionsTabs.TabIndex = 7;
			// 
			// presetTab
			// 
			this.presetTab.Controls.Add(this.statusLabel);
			this.presetTab.Controls.Add(this.deleteButton);
			this.presetTab.Controls.Add(this.saveAsButton);
			this.presetTab.Controls.Add(this.saveButton);
			this.presetTab.Controls.Add(this.reloadButton);
			this.presetTab.Controls.Add(this.presetBox);
			this.presetTab.Controls.Add(this.presetLabel);
			this.presetTab.Location = new System.Drawing.Point(4, 25);
			this.presetTab.Name = "presetTab";
			this.presetTab.Padding = new System.Windows.Forms.Padding(9);
			this.presetTab.Size = new System.Drawing.Size(752, 288);
			this.presetTab.TabIndex = 0;
			this.presetTab.Text = "Preset";
			this.presetTab.UseVisualStyleBackColor = true;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(474, 37);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 16);
			this.statusLabel.TabIndex = 6;
			// 
			// deleteButton
			// 
			this.deleteButton.Enabled = false;
			this.deleteButton.Location = new System.Drawing.Point(287, 68);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(85, 30);
			this.deleteButton.TabIndex = 5;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// saveAsButton
			// 
			this.saveAsButton.Location = new System.Drawing.Point(196, 68);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(85, 30);
			this.saveAsButton.TabIndex = 4;
			this.saveAsButton.Text = "Save As...";
			this.saveAsButton.UseVisualStyleBackColor = true;
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(105, 68);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(85, 30);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// reloadButton
			// 
			this.reloadButton.Location = new System.Drawing.Point(14, 68);
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.Size = new System.Drawing.Size(85, 30);
			this.reloadButton.TabIndex = 2;
			this.reloadButton.Text = "Reload";
			this.reloadButton.UseVisualStyleBackColor = true;
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// presetBox
			// 
			this.presetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.presetBox.FormattingEnabled = true;
			this.presetBox.Location = new System.Drawing.Point(15, 34);
			this.presetBox.Name = "presetBox";
			this.presetBox.Size = new System.Drawing.Size(450, 24);
			this.presetBox.Sorted = true;
			this.presetBox.TabIndex = 1;
			this.presetBox.SelectedIndexChanged += new System.EventHandler(this.presetBox_SelectedIndexChanged);
			this.presetBox.SelectionChangeCommitted += new System.EventHandler(this.presetBox_SelectionChangeCommitted);
			// 
			// presetLabel
			// 
			this.presetLabel.AutoSize = true;
			this.presetLabel.Location = new System.Drawing.Point(12, 12);
			this.presetLabel.Name = "presetLabel";
			this.presetLabel.Size = new System.Drawing.Size(44, 16);
			this.presetLabel.TabIndex = 0;
			this.presetLabel.Text = "Preset:";
			// 
			// outputTab
			// 
			this.outputTab.Controls.Add(this.saveLogCheck);
			this.outputTab.Controls.Add(this.subtitlesStreamsLabel);
			this.outputTab.Controls.Add(this.audioStreamsLabel);
			this.outputTab.Controls.Add(this.videoStreamsLabel);
			this.outputTab.Controls.Add(this.subtitlesStreamsBox);
			this.outputTab.Controls.Add(this.includeSubtitlesCheck);
			this.outputTab.Controls.Add(this.audioStreamsBox);
			this.outputTab.Controls.Add(this.videoStreamsBox);
			this.outputTab.Controls.Add(this.fileExtBox);
			this.outputTab.Controls.Add(this.fileExtLabel);
			this.outputTab.Controls.Add(this.browseButton);
			this.outputTab.Controls.Add(this.outputFolderLabel);
			this.outputTab.Controls.Add(this.outputFolderBox);
			this.outputTab.Controls.Add(this.includeAudioCheck);
			this.outputTab.Controls.Add(this.includeVideoCheck);
			this.outputTab.Controls.Add(this.fileFormatBox);
			this.outputTab.Controls.Add(this.fileFormatLabel);
			this.outputTab.Location = new System.Drawing.Point(4, 25);
			this.outputTab.Name = "outputTab";
			this.outputTab.Padding = new System.Windows.Forms.Padding(9);
			this.outputTab.Size = new System.Drawing.Size(752, 288);
			this.outputTab.TabIndex = 1;
			this.outputTab.Text = "Output";
			this.outputTab.UseVisualStyleBackColor = true;
			// 
			// saveLogCheck
			// 
			this.saveLogCheck.AutoSize = true;
			this.saveLogCheck.Location = new System.Drawing.Point(15, 249);
			this.saveLogCheck.Name = "saveLogCheck";
			this.saveLogCheck.Size = new System.Drawing.Size(88, 20);
			this.saveLogCheck.TabIndex = 16;
			this.saveLogCheck.Text = "Save log fie";
			this.saveLogCheck.UseVisualStyleBackColor = true;
			// 
			// subtitlesStreamsLabel
			// 
			this.subtitlesStreamsLabel.AutoSize = true;
			this.subtitlesStreamsLabel.Location = new System.Drawing.Point(440, 42);
			this.subtitlesStreamsLabel.Name = "subtitlesStreamsLabel";
			this.subtitlesStreamsLabel.Size = new System.Drawing.Size(94, 16);
			this.subtitlesStreamsLabel.TabIndex = 11;
			this.subtitlesStreamsLabel.Text = "Source stream(s):";
			// 
			// audioStreamsLabel
			// 
			this.audioStreamsLabel.AutoSize = true;
			this.audioStreamsLabel.Location = new System.Drawing.Point(212, 102);
			this.audioStreamsLabel.Name = "audioStreamsLabel";
			this.audioStreamsLabel.Size = new System.Drawing.Size(94, 16);
			this.audioStreamsLabel.TabIndex = 8;
			this.audioStreamsLabel.Text = "Source stream(s):";
			// 
			// videoStreamsLabel
			// 
			this.videoStreamsLabel.AutoSize = true;
			this.videoStreamsLabel.Location = new System.Drawing.Point(212, 42);
			this.videoStreamsLabel.Name = "videoStreamsLabel";
			this.videoStreamsLabel.Size = new System.Drawing.Size(94, 16);
			this.videoStreamsLabel.TabIndex = 5;
			this.videoStreamsLabel.Text = "Source stream(s):";
			// 
			// subtitlesStreamsBox
			// 
			this.subtitlesStreamsBox.Location = new System.Drawing.Point(541, 39);
			this.subtitlesStreamsBox.Name = "subtitlesStreamsBox";
			this.subtitlesStreamsBox.Size = new System.Drawing.Size(80, 20);
			this.subtitlesStreamsBox.TabIndex = 12;
			this.subtitlesStreamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// includeSubtitlesCheck
			// 
			this.includeSubtitlesCheck.AutoSize = true;
			this.includeSubtitlesCheck.Checked = true;
			this.includeSubtitlesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.includeSubtitlesCheck.Location = new System.Drawing.Point(424, 13);
			this.includeSubtitlesCheck.Name = "includeSubtitlesCheck";
			this.includeSubtitlesCheck.Size = new System.Drawing.Size(111, 20);
			this.includeSubtitlesCheck.TabIndex = 10;
			this.includeSubtitlesCheck.Text = "Include subtitles";
			this.includeSubtitlesCheck.UseVisualStyleBackColor = true;
			this.includeSubtitlesCheck.CheckedChanged += new System.EventHandler(this.includeSubtitlesCheck_CheckedChanged);
			// 
			// audioStreamsBox
			// 
			this.audioStreamsBox.Location = new System.Drawing.Point(313, 99);
			this.audioStreamsBox.Name = "audioStreamsBox";
			this.audioStreamsBox.Size = new System.Drawing.Size(80, 20);
			this.audioStreamsBox.TabIndex = 9;
			this.audioStreamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// videoStreamsBox
			// 
			this.videoStreamsBox.Location = new System.Drawing.Point(313, 39);
			this.videoStreamsBox.Name = "videoStreamsBox";
			this.videoStreamsBox.Size = new System.Drawing.Size(80, 20);
			this.videoStreamsBox.TabIndex = 6;
			this.videoStreamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// fileExtBox
			// 
			this.fileExtBox.Location = new System.Drawing.Point(15, 87);
			this.fileExtBox.Name = "fileExtBox";
			this.fileExtBox.Size = new System.Drawing.Size(120, 20);
			this.fileExtBox.TabIndex = 3;
			this.fileExtBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// fileExtLabel
			// 
			this.fileExtLabel.AutoSize = true;
			this.fileExtLabel.Location = new System.Drawing.Point(12, 65);
			this.fileExtLabel.Name = "fileExtLabel";
			this.fileExtLabel.Size = new System.Drawing.Size(108, 16);
			this.fileExtLabel.TabIndex = 2;
			this.fileExtLabel.Text = "Filename extension:";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(442, 218);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 25);
			this.browseButton.TabIndex = 15;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// outputFolderLabel
			// 
			this.outputFolderLabel.AutoSize = true;
			this.outputFolderLabel.Location = new System.Drawing.Point(12, 198);
			this.outputFolderLabel.Name = "outputFolderLabel";
			this.outputFolderLabel.Size = new System.Drawing.Size(83, 16);
			this.outputFolderLabel.TabIndex = 13;
			this.outputFolderLabel.Text = "Output folder:";
			// 
			// outputFolderBox
			// 
			this.outputFolderBox.Location = new System.Drawing.Point(15, 220);
			this.outputFolderBox.Name = "outputFolderBox";
			this.outputFolderBox.Size = new System.Drawing.Size(420, 20);
			this.outputFolderBox.TabIndex = 14;
			// 
			// includeAudioCheck
			// 
			this.includeAudioCheck.AutoSize = true;
			this.includeAudioCheck.Checked = true;
			this.includeAudioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.includeAudioCheck.Location = new System.Drawing.Point(196, 73);
			this.includeAudioCheck.Name = "includeAudioCheck";
			this.includeAudioCheck.Size = new System.Drawing.Size(95, 20);
			this.includeAudioCheck.TabIndex = 7;
			this.includeAudioCheck.Text = "Include audio";
			this.includeAudioCheck.UseVisualStyleBackColor = true;
			this.includeAudioCheck.CheckedChanged += new System.EventHandler(this.includeAudioCheck_CheckedChanged);
			// 
			// includeVideoCheck
			// 
			this.includeVideoCheck.AutoSize = true;
			this.includeVideoCheck.Checked = true;
			this.includeVideoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.includeVideoCheck.Location = new System.Drawing.Point(196, 13);
			this.includeVideoCheck.Name = "includeVideoCheck";
			this.includeVideoCheck.Size = new System.Drawing.Size(96, 20);
			this.includeVideoCheck.TabIndex = 4;
			this.includeVideoCheck.Text = "Include video";
			this.includeVideoCheck.UseVisualStyleBackColor = true;
			this.includeVideoCheck.CheckedChanged += new System.EventHandler(this.includeVideoCheck_CheckedChanged);
			// 
			// fileFormatBox
			// 
			this.fileFormatBox.Location = new System.Drawing.Point(15, 34);
			this.fileFormatBox.Name = "fileFormatBox";
			this.fileFormatBox.Size = new System.Drawing.Size(120, 20);
			this.fileFormatBox.TabIndex = 1;
			this.fileFormatBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// fileFormatLabel
			// 
			this.fileFormatLabel.AutoSize = true;
			this.fileFormatLabel.Location = new System.Drawing.Point(12, 12);
			this.fileFormatLabel.Name = "fileFormatLabel";
			this.fileFormatLabel.Size = new System.Drawing.Size(67, 16);
			this.fileFormatLabel.TabIndex = 0;
			this.fileFormatLabel.Text = "File format:";
			// 
			// videoTab
			// 
			this.videoTab.Controls.Add(this.fpsLabel);
			this.videoTab.Controls.Add(this.videoKbpsLabel);
			this.videoTab.Controls.Add(this.pixelsLabel);
			this.videoTab.Controls.Add(this.videoCodecBox);
			this.videoTab.Controls.Add(this.videoCodecLabel);
			this.videoTab.Controls.Add(this.groupBox1);
			this.videoTab.Controls.Add(this.videoBitrateBox);
			this.videoTab.Controls.Add(this.videoBitrateLabel);
			this.videoTab.Controls.Add(this.frameRateBox);
			this.videoTab.Controls.Add(this.frameRateLabel);
			this.videoTab.Controls.Add(this.darBox);
			this.videoTab.Controls.Add(this.darLabel);
			this.videoTab.Controls.Add(this.xLabel);
			this.videoTab.Controls.Add(this.heightBox);
			this.videoTab.Controls.Add(this.widthBox);
			this.videoTab.Controls.Add(this.sizeLabel);
			this.videoTab.Location = new System.Drawing.Point(4, 25);
			this.videoTab.Name = "videoTab";
			this.videoTab.Padding = new System.Windows.Forms.Padding(9);
			this.videoTab.Size = new System.Drawing.Size(752, 288);
			this.videoTab.TabIndex = 2;
			this.videoTab.Text = "Video";
			this.videoTab.UseVisualStyleBackColor = true;
			// 
			// fpsLabel
			// 
			this.fpsLabel.AutoSize = true;
			this.fpsLabel.Location = new System.Drawing.Point(141, 249);
			this.fpsLabel.Name = "fpsLabel";
			this.fpsLabel.Size = new System.Drawing.Size(24, 16);
			this.fpsLabel.TabIndex = 14;
			this.fpsLabel.Text = "fps";
			// 
			// videoKbpsLabel
			// 
			this.videoKbpsLabel.AutoSize = true;
			this.videoKbpsLabel.Location = new System.Drawing.Point(141, 143);
			this.videoKbpsLabel.Name = "videoKbpsLabel";
			this.videoKbpsLabel.Size = new System.Drawing.Size(32, 16);
			this.videoKbpsLabel.TabIndex = 9;
			this.videoKbpsLabel.Text = "kbps";
			// 
			// pixelsLabel
			// 
			this.pixelsLabel.AutoSize = true;
			this.pixelsLabel.Location = new System.Drawing.Point(208, 90);
			this.pixelsLabel.Name = "pixelsLabel";
			this.pixelsLabel.Size = new System.Drawing.Size(37, 16);
			this.pixelsLabel.TabIndex = 6;
			this.pixelsLabel.Text = "pixels";
			// 
			// videoCodecBox
			// 
			this.videoCodecBox.Location = new System.Drawing.Point(15, 34);
			this.videoCodecBox.Name = "videoCodecBox";
			this.videoCodecBox.Size = new System.Drawing.Size(120, 20);
			this.videoCodecBox.TabIndex = 1;
			this.videoCodecBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// videoCodecLabel
			// 
			this.videoCodecLabel.AutoSize = true;
			this.videoCodecLabel.Location = new System.Drawing.Point(12, 12);
			this.videoCodecLabel.Name = "videoCodecLabel";
			this.videoCodecLabel.Size = new System.Drawing.Size(43, 16);
			this.videoCodecLabel.TabIndex = 0;
			this.videoCodecLabel.Text = "Codec:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rightLabel);
			this.groupBox1.Controls.Add(this.rightBox);
			this.groupBox1.Controls.Add(this.bottomLabel);
			this.groupBox1.Controls.Add(this.bottomBox);
			this.groupBox1.Controls.Add(this.leftLabel);
			this.groupBox1.Controls.Add(this.leftBox);
			this.groupBox1.Controls.Add(this.topLabel);
			this.groupBox1.Controls.Add(this.topBox);
			this.groupBox1.Location = new System.Drawing.Point(281, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 188);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Crop source";
			// 
			// rightLabel
			// 
			this.rightLabel.AutoSize = true;
			this.rightLabel.Location = new System.Drawing.Point(203, 75);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(39, 16);
			this.rightLabel.TabIndex = 4;
			this.rightLabel.Text = "Right:";
			// 
			// rightBox
			// 
			this.rightBox.Location = new System.Drawing.Point(206, 94);
			this.rightBox.Name = "rightBox";
			this.rightBox.Size = new System.Drawing.Size(60, 20);
			this.rightBox.TabIndex = 5;
			this.rightBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// bottomLabel
			// 
			this.bottomLabel.AutoSize = true;
			this.bottomLabel.Location = new System.Drawing.Point(114, 125);
			this.bottomLabel.Name = "bottomLabel";
			this.bottomLabel.Size = new System.Drawing.Size(51, 16);
			this.bottomLabel.TabIndex = 6;
			this.bottomLabel.Text = "Bottom:";
			// 
			// bottomBox
			// 
			this.bottomBox.Location = new System.Drawing.Point(117, 144);
			this.bottomBox.Name = "bottomBox";
			this.bottomBox.Size = new System.Drawing.Size(60, 20);
			this.bottomBox.TabIndex = 7;
			this.bottomBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// leftLabel
			// 
			this.leftLabel.AutoSize = true;
			this.leftLabel.Location = new System.Drawing.Point(25, 75);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(32, 16);
			this.leftLabel.TabIndex = 2;
			this.leftLabel.Text = "Left:";
			// 
			// leftBox
			// 
			this.leftBox.Location = new System.Drawing.Point(28, 94);
			this.leftBox.Name = "leftBox";
			this.leftBox.Size = new System.Drawing.Size(60, 20);
			this.leftBox.TabIndex = 3;
			this.leftBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Location = new System.Drawing.Point(114, 25);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(32, 16);
			this.topLabel.TabIndex = 0;
			this.topLabel.Text = "Top:";
			// 
			// topBox
			// 
			this.topBox.Location = new System.Drawing.Point(117, 44);
			this.topBox.Name = "topBox";
			this.topBox.Size = new System.Drawing.Size(60, 20);
			this.topBox.TabIndex = 1;
			this.topBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// videoBitrateBox
			// 
			this.videoBitrateBox.Location = new System.Drawing.Point(15, 140);
			this.videoBitrateBox.Name = "videoBitrateBox";
			this.videoBitrateBox.Size = new System.Drawing.Size(120, 20);
			this.videoBitrateBox.TabIndex = 8;
			this.videoBitrateBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// videoBitrateLabel
			// 
			this.videoBitrateLabel.AutoSize = true;
			this.videoBitrateLabel.Location = new System.Drawing.Point(12, 118);
			this.videoBitrateLabel.Name = "videoBitrateLabel";
			this.videoBitrateLabel.Size = new System.Drawing.Size(47, 16);
			this.videoBitrateLabel.TabIndex = 7;
			this.videoBitrateLabel.Text = "Bitrate:";
			// 
			// frameRateBox
			// 
			this.frameRateBox.Location = new System.Drawing.Point(15, 246);
			this.frameRateBox.Name = "frameRateBox";
			this.frameRateBox.Size = new System.Drawing.Size(120, 20);
			this.frameRateBox.TabIndex = 13;
			this.frameRateBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// frameRateLabel
			// 
			this.frameRateLabel.AutoSize = true;
			this.frameRateLabel.Location = new System.Drawing.Point(12, 224);
			this.frameRateLabel.Name = "frameRateLabel";
			this.frameRateLabel.Size = new System.Drawing.Size(66, 16);
			this.frameRateLabel.TabIndex = 12;
			this.frameRateLabel.Text = "Frame rate:";
			// 
			// darBox
			// 
			this.darBox.Location = new System.Drawing.Point(15, 193);
			this.darBox.Name = "darBox";
			this.darBox.Size = new System.Drawing.Size(120, 20);
			this.darBox.TabIndex = 11;
			this.darBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// darLabel
			// 
			this.darLabel.AutoSize = true;
			this.darLabel.Location = new System.Drawing.Point(12, 171);
			this.darLabel.Name = "darLabel";
			this.darLabel.Size = new System.Drawing.Size(115, 16);
			this.darLabel.TabIndex = 10;
			this.darLabel.Text = "Display aspect ratio:";
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(101, 90);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(15, 16);
			this.xLabel.TabIndex = 4;
			this.xLabel.Text = "X";
			// 
			// heightBox
			// 
			this.heightBox.Location = new System.Drawing.Point(122, 87);
			this.heightBox.Name = "heightBox";
			this.heightBox.Size = new System.Drawing.Size(80, 20);
			this.heightBox.TabIndex = 5;
			this.heightBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// widthBox
			// 
			this.widthBox.Location = new System.Drawing.Point(15, 87);
			this.widthBox.Name = "widthBox";
			this.widthBox.Size = new System.Drawing.Size(80, 20);
			this.widthBox.TabIndex = 3;
			this.widthBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(12, 65);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(31, 16);
			this.sizeLabel.TabIndex = 2;
			this.sizeLabel.Text = "Size:";
			// 
			// audioTab
			// 
			this.audioTab.Controls.Add(this.percentLabel);
			this.audioTab.Controls.Add(this.volumeBox);
			this.audioTab.Controls.Add(this.volumeLabel);
			this.audioTab.Controls.Add(this.hzLabel);
			this.audioTab.Controls.Add(this.audioKbpsLabel);
			this.audioTab.Controls.Add(this.audioCodecBox);
			this.audioTab.Controls.Add(this.audioCodecLabel);
			this.audioTab.Controls.Add(this.sampleRateBox);
			this.audioTab.Controls.Add(this.sampleRateLabel);
			this.audioTab.Controls.Add(this.channelCountBox);
			this.audioTab.Controls.Add(this.channelCountLabel);
			this.audioTab.Controls.Add(this.audioBitrateBox);
			this.audioTab.Controls.Add(this.audioBitrateLabel);
			this.audioTab.Location = new System.Drawing.Point(4, 25);
			this.audioTab.Name = "audioTab";
			this.audioTab.Padding = new System.Windows.Forms.Padding(9);
			this.audioTab.Size = new System.Drawing.Size(752, 288);
			this.audioTab.TabIndex = 3;
			this.audioTab.Text = "Audio";
			this.audioTab.UseVisualStyleBackColor = true;
			// 
			// percentLabel
			// 
			this.percentLabel.AutoSize = true;
			this.percentLabel.Location = new System.Drawing.Point(141, 249);
			this.percentLabel.Name = "percentLabel";
			this.percentLabel.Size = new System.Drawing.Size(17, 16);
			this.percentLabel.TabIndex = 12;
			this.percentLabel.Text = "%";
			// 
			// volumeBox
			// 
			this.volumeBox.Location = new System.Drawing.Point(15, 246);
			this.volumeBox.Name = "volumeBox";
			this.volumeBox.Size = new System.Drawing.Size(120, 20);
			this.volumeBox.TabIndex = 11;
			this.volumeBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// volumeLabel
			// 
			this.volumeLabel.AutoSize = true;
			this.volumeLabel.Location = new System.Drawing.Point(12, 224);
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(51, 16);
			this.volumeLabel.TabIndex = 10;
			this.volumeLabel.Text = "Volume:";
			// 
			// hzLabel
			// 
			this.hzLabel.AutoSize = true;
			this.hzLabel.Location = new System.Drawing.Point(141, 196);
			this.hzLabel.Name = "hzLabel";
			this.hzLabel.Size = new System.Drawing.Size(21, 16);
			this.hzLabel.TabIndex = 9;
			this.hzLabel.Text = "Hz";
			// 
			// audioKbpsLabel
			// 
			this.audioKbpsLabel.AutoSize = true;
			this.audioKbpsLabel.Location = new System.Drawing.Point(141, 90);
			this.audioKbpsLabel.Name = "audioKbpsLabel";
			this.audioKbpsLabel.Size = new System.Drawing.Size(32, 16);
			this.audioKbpsLabel.TabIndex = 4;
			this.audioKbpsLabel.Text = "kbps";
			// 
			// audioCodecBox
			// 
			this.audioCodecBox.Location = new System.Drawing.Point(15, 34);
			this.audioCodecBox.Name = "audioCodecBox";
			this.audioCodecBox.Size = new System.Drawing.Size(120, 20);
			this.audioCodecBox.TabIndex = 1;
			this.audioCodecBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// audioCodecLabel
			// 
			this.audioCodecLabel.AutoSize = true;
			this.audioCodecLabel.Location = new System.Drawing.Point(12, 12);
			this.audioCodecLabel.Name = "audioCodecLabel";
			this.audioCodecLabel.Size = new System.Drawing.Size(43, 16);
			this.audioCodecLabel.TabIndex = 0;
			this.audioCodecLabel.Text = "Codec:";
			// 
			// sampleRateBox
			// 
			this.sampleRateBox.Location = new System.Drawing.Point(15, 193);
			this.sampleRateBox.Name = "sampleRateBox";
			this.sampleRateBox.Size = new System.Drawing.Size(120, 20);
			this.sampleRateBox.TabIndex = 8;
			this.sampleRateBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// sampleRateLabel
			// 
			this.sampleRateLabel.AutoSize = true;
			this.sampleRateLabel.Location = new System.Drawing.Point(12, 171);
			this.sampleRateLabel.Name = "sampleRateLabel";
			this.sampleRateLabel.Size = new System.Drawing.Size(72, 16);
			this.sampleRateLabel.TabIndex = 7;
			this.sampleRateLabel.Text = "Sample rate:";
			// 
			// channelCountBox
			// 
			this.channelCountBox.Location = new System.Drawing.Point(15, 140);
			this.channelCountBox.Name = "channelCountBox";
			this.channelCountBox.Size = new System.Drawing.Size(120, 20);
			this.channelCountBox.TabIndex = 6;
			this.channelCountBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// channelCountLabel
			// 
			this.channelCountLabel.AutoSize = true;
			this.channelCountLabel.Location = new System.Drawing.Point(12, 118);
			this.channelCountLabel.Name = "channelCountLabel";
			this.channelCountLabel.Size = new System.Drawing.Size(83, 16);
			this.channelCountLabel.TabIndex = 5;
			this.channelCountLabel.Text = "Channel count:";
			// 
			// audioBitrateBox
			// 
			this.audioBitrateBox.Location = new System.Drawing.Point(15, 87);
			this.audioBitrateBox.Name = "audioBitrateBox";
			this.audioBitrateBox.Size = new System.Drawing.Size(120, 20);
			this.audioBitrateBox.TabIndex = 3;
			this.audioBitrateBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// audioBitrateLabel
			// 
			this.audioBitrateLabel.AutoSize = true;
			this.audioBitrateLabel.Location = new System.Drawing.Point(12, 65);
			this.audioBitrateLabel.Name = "audioBitrateLabel";
			this.audioBitrateLabel.Size = new System.Drawing.Size(47, 16);
			this.audioBitrateLabel.TabIndex = 2;
			this.audioBitrateLabel.Text = "Bitrate:";
			// 
			// advancedTab
			// 
			this.advancedTab.Controls.Add(this.videoFiltersBox);
			this.advancedTab.Controls.Add(this.videoFiltersLabel);
			this.advancedTab.Controls.Add(this.inputParamsBox);
			this.advancedTab.Controls.Add(this.inputParamsLabel);
			this.advancedTab.Controls.Add(this.outputParamsBox);
			this.advancedTab.Controls.Add(this.outputParamsLabel);
			this.advancedTab.Controls.Add(this.audioFiltersBox);
			this.advancedTab.Controls.Add(this.audioFiltersLabel);
			this.advancedTab.Controls.Add(this.globalParamsBox);
			this.advancedTab.Controls.Add(this.globalParamsLabel);
			this.advancedTab.Location = new System.Drawing.Point(4, 25);
			this.advancedTab.Name = "advancedTab";
			this.advancedTab.Padding = new System.Windows.Forms.Padding(9);
			this.advancedTab.Size = new System.Drawing.Size(752, 288);
			this.advancedTab.TabIndex = 4;
			this.advancedTab.Text = "Advanced";
			this.advancedTab.UseVisualStyleBackColor = true;
			// 
			// videoFiltersBox
			// 
			this.videoFiltersBox.Location = new System.Drawing.Point(15, 140);
			this.videoFiltersBox.Name = "videoFiltersBox";
			this.videoFiltersBox.Size = new System.Drawing.Size(450, 20);
			this.videoFiltersBox.TabIndex = 5;
			this.videoFiltersBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// videoFiltersLabel
			// 
			this.videoFiltersLabel.AutoSize = true;
			this.videoFiltersLabel.Location = new System.Drawing.Point(12, 118);
			this.videoFiltersLabel.Name = "videoFiltersLabel";
			this.videoFiltersLabel.Size = new System.Drawing.Size(175, 16);
			this.videoFiltersLabel.TabIndex = 4;
			this.videoFiltersLabel.Text = "Additional FFmpeg video filters:";
			// 
			// inputParamsBox
			// 
			this.inputParamsBox.Location = new System.Drawing.Point(15, 87);
			this.inputParamsBox.Name = "inputParamsBox";
			this.inputParamsBox.Size = new System.Drawing.Size(450, 20);
			this.inputParamsBox.TabIndex = 3;
			this.inputParamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// inputParamsLabel
			// 
			this.inputParamsLabel.AutoSize = true;
			this.inputParamsLabel.Location = new System.Drawing.Point(12, 65);
			this.inputParamsLabel.Name = "inputParamsLabel";
			this.inputParamsLabel.Size = new System.Drawing.Size(200, 16);
			this.inputParamsLabel.TabIndex = 2;
			this.inputParamsLabel.Text = "Additional FFmpeg input parameters:";
			// 
			// outputParamsBox
			// 
			this.outputParamsBox.Location = new System.Drawing.Point(15, 246);
			this.outputParamsBox.Name = "outputParamsBox";
			this.outputParamsBox.Size = new System.Drawing.Size(450, 20);
			this.outputParamsBox.TabIndex = 9;
			this.outputParamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// outputParamsLabel
			// 
			this.outputParamsLabel.AutoSize = true;
			this.outputParamsLabel.Location = new System.Drawing.Point(12, 224);
			this.outputParamsLabel.Name = "outputParamsLabel";
			this.outputParamsLabel.Size = new System.Drawing.Size(209, 16);
			this.outputParamsLabel.TabIndex = 8;
			this.outputParamsLabel.Text = "Additional FFmpeg output parameters:";
			// 
			// audioFiltersBox
			// 
			this.audioFiltersBox.Location = new System.Drawing.Point(15, 193);
			this.audioFiltersBox.Name = "audioFiltersBox";
			this.audioFiltersBox.Size = new System.Drawing.Size(450, 20);
			this.audioFiltersBox.TabIndex = 7;
			this.audioFiltersBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// audioFiltersLabel
			// 
			this.audioFiltersLabel.AutoSize = true;
			this.audioFiltersLabel.Location = new System.Drawing.Point(12, 171);
			this.audioFiltersLabel.Name = "audioFiltersLabel";
			this.audioFiltersLabel.Size = new System.Drawing.Size(174, 16);
			this.audioFiltersLabel.TabIndex = 6;
			this.audioFiltersLabel.Text = "Additional FFmpeg audio filters:";
			// 
			// globalParamsBox
			// 
			this.globalParamsBox.Location = new System.Drawing.Point(15, 34);
			this.globalParamsBox.Name = "globalParamsBox";
			this.globalParamsBox.Size = new System.Drawing.Size(450, 20);
			this.globalParamsBox.TabIndex = 1;
			this.globalParamsBox.TextChanged += new System.EventHandler(this.OptionValueChanged);
			// 
			// globalParamsLabel
			// 
			this.globalParamsLabel.AutoSize = true;
			this.globalParamsLabel.Location = new System.Drawing.Point(12, 12);
			this.globalParamsLabel.Name = "globalParamsLabel";
			this.globalParamsLabel.Size = new System.Drawing.Size(206, 16);
			this.globalParamsLabel.TabIndex = 0;
			this.globalParamsLabel.Text = "Additional FFmpeg global parameters:";
			// 
			// aboutButton
			// 
			this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutButton.Image = global::Yaffmi.Properties.Resources.aboutIcon;
			this.aboutButton.Location = new System.Drawing.Point(682, 12);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(90, 60);
			this.aboutButton.TabIndex = 5;
			this.aboutButton.Text = "About Yaffmi";
			this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// settingsButton
			// 
			this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsButton.Image = global::Yaffmi.Properties.Resources.settingsIcon;
			this.settingsButton.Location = new System.Drawing.Point(586, 12);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(90, 60);
			this.settingsButton.TabIndex = 4;
			this.settingsButton.Text = "Settings...";
			this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.settingsButton.UseVisualStyleBackColor = true;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// convertButton
			// 
			this.convertButton.Image = global::Yaffmi.Properties.Resources.convertIcon;
			this.convertButton.Location = new System.Drawing.Point(320, 12);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(90, 60);
			this.convertButton.TabIndex = 3;
			this.convertButton.Text = "Convert";
			this.convertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// clearListButton
			// 
			this.clearListButton.Image = global::Yaffmi.Properties.Resources.clearListIcon;
			this.clearListButton.Location = new System.Drawing.Point(204, 12);
			this.clearListButton.Name = "clearListButton";
			this.clearListButton.Size = new System.Drawing.Size(90, 60);
			this.clearListButton.TabIndex = 2;
			this.clearListButton.Text = "Clear List";
			this.clearListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.clearListButton.UseVisualStyleBackColor = true;
			this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
			// 
			// removeItemButton
			// 
			this.removeItemButton.Image = global::Yaffmi.Properties.Resources.removeItemIcon;
			this.removeItemButton.Location = new System.Drawing.Point(108, 12);
			this.removeItemButton.Name = "removeItemButton";
			this.removeItemButton.Size = new System.Drawing.Size(90, 60);
			this.removeItemButton.TabIndex = 1;
			this.removeItemButton.Text = "Remove";
			this.removeItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.removeItemButton.UseVisualStyleBackColor = true;
			this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
			// 
			// addItemButton
			// 
			this.addItemButton.Image = global::Yaffmi.Properties.Resources.addItemIcon;
			this.addItemButton.Location = new System.Drawing.Point(12, 12);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(90, 60);
			this.addItemButton.TabIndex = 0;
			this.addItemButton.Text = "Add...";
			this.addItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.addItemButton.UseVisualStyleBackColor = true;
			this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 662);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.optionsTabs);
			this.Controls.Add(this.fileListBox);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.clearListButton);
			this.Controls.Add(this.removeItemButton);
			this.Controls.Add(this.addItemButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(650, 570);
			this.Name = "MainWindow";
			this.Text = "Yaffmi";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.optionsTabs.ResumeLayout(false);
			this.presetTab.ResumeLayout(false);
			this.presetTab.PerformLayout();
			this.outputTab.ResumeLayout(false);
			this.outputTab.PerformLayout();
			this.videoTab.ResumeLayout(false);
			this.videoTab.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.audioTab.ResumeLayout(false);
			this.audioTab.PerformLayout();
			this.advancedTab.ResumeLayout(false);
			this.advancedTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addItemButton;
		private System.Windows.Forms.Button removeItemButton;
		private System.Windows.Forms.Button clearListButton;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.ListBox fileListBox;
		private System.Windows.Forms.TabControl optionsTabs;
		private System.Windows.Forms.TabPage presetTab;
		private System.Windows.Forms.TabPage outputTab;
		private System.Windows.Forms.TabPage videoTab;
		private System.Windows.Forms.TabPage audioTab;
		private System.Windows.Forms.TabPage advancedTab;
		private System.Windows.Forms.Label presetLabel;
		private System.Windows.Forms.ComboBox presetBox;
		private System.Windows.Forms.Button saveAsButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button reloadButton;
		private System.Windows.Forms.TextBox fileFormatBox;
		private System.Windows.Forms.Label fileFormatLabel;
		private System.Windows.Forms.Label outputFolderLabel;
		private System.Windows.Forms.TextBox outputFolderBox;
		private System.Windows.Forms.CheckBox includeAudioCheck;
		private System.Windows.Forms.CheckBox includeVideoCheck;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.TextBox rightBox;
		private System.Windows.Forms.Label bottomLabel;
		private System.Windows.Forms.TextBox bottomBox;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.TextBox leftBox;
		private System.Windows.Forms.Label topLabel;
		private System.Windows.Forms.TextBox topBox;
		private System.Windows.Forms.TextBox videoBitrateBox;
		private System.Windows.Forms.Label videoBitrateLabel;
		private System.Windows.Forms.TextBox frameRateBox;
		private System.Windows.Forms.Label frameRateLabel;
		private System.Windows.Forms.TextBox darBox;
		private System.Windows.Forms.Label darLabel;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.TextBox heightBox;
		private System.Windows.Forms.TextBox widthBox;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.TextBox videoCodecBox;
		private System.Windows.Forms.Label videoCodecLabel;
		private System.Windows.Forms.TextBox audioCodecBox;
		private System.Windows.Forms.Label audioCodecLabel;
		private System.Windows.Forms.TextBox sampleRateBox;
		private System.Windows.Forms.Label sampleRateLabel;
		private System.Windows.Forms.TextBox channelCountBox;
		private System.Windows.Forms.Label channelCountLabel;
		private System.Windows.Forms.TextBox audioBitrateBox;
		private System.Windows.Forms.Label audioBitrateLabel;
		private System.Windows.Forms.Label pixelsLabel;
		private System.Windows.Forms.Label fpsLabel;
		private System.Windows.Forms.Label videoKbpsLabel;
		private System.Windows.Forms.Label hzLabel;
		private System.Windows.Forms.Label audioKbpsLabel;
		private System.Windows.Forms.Label percentLabel;
		private System.Windows.Forms.TextBox volumeBox;
		private System.Windows.Forms.Label volumeLabel;
		private System.Windows.Forms.TextBox globalParamsBox;
		private System.Windows.Forms.Label globalParamsLabel;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.TextBox outputParamsBox;
		private System.Windows.Forms.Label outputParamsLabel;
		private System.Windows.Forms.TextBox audioFiltersBox;
		private System.Windows.Forms.Label audioFiltersLabel;
		private System.Windows.Forms.TextBox videoFiltersBox;
		private System.Windows.Forms.Label videoFiltersLabel;
		private System.Windows.Forms.TextBox inputParamsBox;
		private System.Windows.Forms.Label inputParamsLabel;
		private System.Windows.Forms.TextBox fileExtBox;
		private System.Windows.Forms.Label fileExtLabel;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label subtitlesStreamsLabel;
		private System.Windows.Forms.Label audioStreamsLabel;
		private System.Windows.Forms.Label videoStreamsLabel;
		private System.Windows.Forms.TextBox subtitlesStreamsBox;
		private System.Windows.Forms.CheckBox includeSubtitlesCheck;
		private System.Windows.Forms.TextBox audioStreamsBox;
		private System.Windows.Forms.TextBox videoStreamsBox;
		private System.Windows.Forms.CheckBox saveLogCheck;
	}
}

