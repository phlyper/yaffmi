namespace Yaffmi
{
	partial class AboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.tabs = new System.Windows.Forms.TabControl();
			this.aboutTab = new System.Windows.Forms.TabPage();
			this.licenseLink = new System.Windows.Forms.LinkLabel();
			this.gplLabel2 = new System.Windows.Forms.Label();
			this.gplLabel1 = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.yaffmiLabel = new System.Windows.Forms.Label();
			this.djCactusIcon = new System.Windows.Forms.PictureBox();
			this.acknowledgmentsTab = new System.Windows.Forms.TabPage();
			this.thanksLabel = new System.Windows.Forms.Label();
			this.cactusLink = new System.Windows.Forms.LinkLabel();
			this.iconsLink = new System.Windows.Forms.LinkLabel();
			this.ffmpegLink = new System.Windows.Forms.LinkLabel();
			this.helpTab = new System.Windows.Forms.TabPage();
			this.helpLink = new System.Windows.Forms.LinkLabel();
			this.closeButton = new System.Windows.Forms.Button();
			this.tabs.SuspendLayout();
			this.aboutTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.djCactusIcon)).BeginInit();
			this.acknowledgmentsTab.SuspendLayout();
			this.helpTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.aboutTab);
			this.tabs.Controls.Add(this.acknowledgmentsTab);
			this.tabs.Controls.Add(this.helpTab);
			this.tabs.Location = new System.Drawing.Point(12, 12);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(600, 378);
			this.tabs.TabIndex = 0;
			// 
			// aboutTab
			// 
			this.aboutTab.Controls.Add(this.licenseLink);
			this.aboutTab.Controls.Add(this.gplLabel2);
			this.aboutTab.Controls.Add(this.gplLabel1);
			this.aboutTab.Controls.Add(this.copyrightLabel);
			this.aboutTab.Controls.Add(this.versionLabel);
			this.aboutTab.Controls.Add(this.yaffmiLabel);
			this.aboutTab.Controls.Add(this.djCactusIcon);
			this.aboutTab.Location = new System.Drawing.Point(4, 25);
			this.aboutTab.Name = "aboutTab";
			this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
			this.aboutTab.Size = new System.Drawing.Size(592, 349);
			this.aboutTab.TabIndex = 0;
			this.aboutTab.Text = "About";
			this.aboutTab.UseVisualStyleBackColor = true;
			// 
			// licenseLink
			// 
			this.licenseLink.AutoSize = true;
			this.licenseLink.Font = new System.Drawing.Font("Ubuntu Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.licenseLink.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.licenseLink.Location = new System.Drawing.Point(22, 307);
			this.licenseLink.MinimumSize = new System.Drawing.Size(480, 0);
			this.licenseLink.Name = "licenseLink";
			this.licenseLink.Size = new System.Drawing.Size(480, 15);
			this.licenseLink.TabIndex = 5;
			this.licenseLink.Text = "Read the full license";
			this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// gplLabel2
			// 
			this.gplLabel2.AutoSize = true;
			this.gplLabel2.Font = new System.Drawing.Font("Ubuntu Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gplLabel2.Location = new System.Drawing.Point(22, 254);
			this.gplLabel2.MaximumSize = new System.Drawing.Size(500, 0);
			this.gplLabel2.MinimumSize = new System.Drawing.Size(480, 0);
			this.gplLabel2.Name = "gplLabel2";
			this.gplLabel2.Size = new System.Drawing.Size(500, 45);
			this.gplLabel2.TabIndex = 4;
			this.gplLabel2.Text = resources.GetString("gplLabel2.Text");
			// 
			// gplLabel1
			// 
			this.gplLabel1.AutoSize = true;
			this.gplLabel1.Font = new System.Drawing.Font("Ubuntu Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gplLabel1.Location = new System.Drawing.Point(22, 201);
			this.gplLabel1.MaximumSize = new System.Drawing.Size(500, 0);
			this.gplLabel1.MinimumSize = new System.Drawing.Size(480, 0);
			this.gplLabel1.Name = "gplLabel1";
			this.gplLabel1.Size = new System.Drawing.Size(494, 45);
			this.gplLabel1.TabIndex = 3;
			this.gplLabel1.Text = resources.GetString("gplLabel1.Text");
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Font = new System.Drawing.Font("Ubuntu Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.copyrightLabel.Location = new System.Drawing.Point(260, 143);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(195, 20);
			this.copyrightLabel.TabIndex = 2;
			this.copyrightLabel.Text = "Copyright © 2014 Ryan Finley";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new System.Drawing.Font("Ubuntu Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versionLabel.Location = new System.Drawing.Point(259, 94);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(171, 26);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.Text = "Version 1 Beta 1";
			// 
			// yaffmiLabel
			// 
			this.yaffmiLabel.AutoSize = true;
			this.yaffmiLabel.Font = new System.Drawing.Font("Ubuntu Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yaffmiLabel.Location = new System.Drawing.Point(255, 42);
			this.yaffmiLabel.Name = "yaffmiLabel";
			this.yaffmiLabel.Size = new System.Drawing.Size(148, 51);
			this.yaffmiLabel.TabIndex = 0;
			this.yaffmiLabel.Text = "Yaffmi";
			// 
			// djCactusIcon
			// 
			this.djCactusIcon.Image = global::Yaffmi.Properties.Resources.djCactus;
			this.djCactusIcon.Location = new System.Drawing.Point(25, 25);
			this.djCactusIcon.Name = "djCactusIcon";
			this.djCactusIcon.Size = new System.Drawing.Size(200, 160);
			this.djCactusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.djCactusIcon.TabIndex = 0;
			this.djCactusIcon.TabStop = false;
			// 
			// acknowledgmentsTab
			// 
			this.acknowledgmentsTab.Controls.Add(this.thanksLabel);
			this.acknowledgmentsTab.Controls.Add(this.cactusLink);
			this.acknowledgmentsTab.Controls.Add(this.iconsLink);
			this.acknowledgmentsTab.Controls.Add(this.ffmpegLink);
			this.acknowledgmentsTab.Location = new System.Drawing.Point(4, 25);
			this.acknowledgmentsTab.Name = "acknowledgmentsTab";
			this.acknowledgmentsTab.Padding = new System.Windows.Forms.Padding(3);
			this.acknowledgmentsTab.Size = new System.Drawing.Size(592, 349);
			this.acknowledgmentsTab.TabIndex = 1;
			this.acknowledgmentsTab.Text = "Acknowledgments";
			this.acknowledgmentsTab.UseVisualStyleBackColor = true;
			// 
			// thanksLabel
			// 
			this.thanksLabel.AutoSize = true;
			this.thanksLabel.Location = new System.Drawing.Point(25, 119);
			this.thanksLabel.MaximumSize = new System.Drawing.Size(500, 0);
			this.thanksLabel.MinimumSize = new System.Drawing.Size(480, 0);
			this.thanksLabel.Name = "thanksLabel";
			this.thanksLabel.Size = new System.Drawing.Size(480, 16);
			this.thanksLabel.TabIndex = 3;
			this.thanksLabel.Text = "Special thanks goes to the people who helped develop and test Yaffmi.";
			// 
			// cactusLink
			// 
			this.cactusLink.AutoSize = true;
			this.cactusLink.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.cactusLink.Location = new System.Drawing.Point(25, 93);
			this.cactusLink.MaximumSize = new System.Drawing.Size(500, 0);
			this.cactusLink.MinimumSize = new System.Drawing.Size(480, 0);
			this.cactusLink.Name = "cactusLink";
			this.cactusLink.Size = new System.Drawing.Size(480, 16);
			this.cactusLink.TabIndex = 2;
			this.cactusLink.Text = "DJ Cactus image is provided by DooFi of Openclipart.";
			this.cactusLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// iconsLink
			// 
			this.iconsLink.AutoSize = true;
			this.iconsLink.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.iconsLink.Location = new System.Drawing.Point(25, 67);
			this.iconsLink.MaximumSize = new System.Drawing.Size(500, 0);
			this.iconsLink.MinimumSize = new System.Drawing.Size(480, 0);
			this.iconsLink.Name = "iconsLink";
			this.iconsLink.Size = new System.Drawing.Size(480, 16);
			this.iconsLink.TabIndex = 1;
			this.iconsLink.Text = "Yaffmi contains icons provided by FatCow.";
			this.iconsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// ffmpegLink
			// 
			this.ffmpegLink.AutoSize = true;
			this.ffmpegLink.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.ffmpegLink.Location = new System.Drawing.Point(25, 25);
			this.ffmpegLink.MaximumSize = new System.Drawing.Size(480, 0);
			this.ffmpegLink.MinimumSize = new System.Drawing.Size(480, 0);
			this.ffmpegLink.Name = "ffmpegLink";
			this.ffmpegLink.Size = new System.Drawing.Size(480, 32);
			this.ffmpegLink.TabIndex = 0;
			this.ffmpegLink.Text = "Yaffmi uses FFmpeg to process media files. Windows builds of FFmpeg are provided " +
    "by Zeranoe.";
			this.ffmpegLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// helpTab
			// 
			this.helpTab.Controls.Add(this.helpLink);
			this.helpTab.Location = new System.Drawing.Point(4, 25);
			this.helpTab.Name = "helpTab";
			this.helpTab.Size = new System.Drawing.Size(592, 349);
			this.helpTab.TabIndex = 2;
			this.helpTab.Text = "Help";
			this.helpTab.UseVisualStyleBackColor = true;
			// 
			// helpLink
			// 
			this.helpLink.AutoSize = true;
			this.helpLink.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.helpLink.Location = new System.Drawing.Point(25, 25);
			this.helpLink.MaximumSize = new System.Drawing.Size(480, 0);
			this.helpLink.MinimumSize = new System.Drawing.Size(480, 0);
			this.helpLink.Name = "helpLink";
			this.helpLink.Size = new System.Drawing.Size(480, 16);
			this.helpLink.TabIndex = 1;
			this.helpLink.Text = "Questions, comments, or bug reports? Email yaffmi@electroworks.net.";
			this.helpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(527, 400);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(85, 30);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// AboutDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.tabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Yaffmi";
			this.tabs.ResumeLayout(false);
			this.aboutTab.ResumeLayout(false);
			this.aboutTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.djCactusIcon)).EndInit();
			this.acknowledgmentsTab.ResumeLayout(false);
			this.acknowledgmentsTab.PerformLayout();
			this.helpTab.ResumeLayout(false);
			this.helpTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage aboutTab;
		private System.Windows.Forms.PictureBox djCactusIcon;
		private System.Windows.Forms.TabPage acknowledgmentsTab;
		private System.Windows.Forms.TabPage helpTab;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label yaffmiLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.LinkLabel licenseLink;
		private System.Windows.Forms.Label gplLabel2;
		private System.Windows.Forms.Label gplLabel1;
		private System.Windows.Forms.LinkLabel cactusLink;
		private System.Windows.Forms.LinkLabel iconsLink;
		private System.Windows.Forms.LinkLabel ffmpegLink;
		private System.Windows.Forms.Label thanksLabel;
		private System.Windows.Forms.LinkLabel helpLink;
	}
}