namespace Yaffmi
{
	partial class SavePresetDialog
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
			this.iconImage = new System.Windows.Forms.PictureBox();
			this.instructionLabel = new System.Windows.Forms.Label();
			this.responseBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
			this.SuspendLayout();
			// 
			// iconImage
			// 
			this.iconImage.Location = new System.Drawing.Point(16, 16);
			this.iconImage.Name = "iconImage";
			this.iconImage.Size = new System.Drawing.Size(32, 32);
			this.iconImage.TabIndex = 0;
			this.iconImage.TabStop = false;
			// 
			// instructionLabel
			// 
			this.instructionLabel.AutoSize = true;
			this.instructionLabel.Location = new System.Drawing.Point(60, 24);
			this.instructionLabel.Name = "instructionLabel";
			this.instructionLabel.Size = new System.Drawing.Size(151, 16);
			this.instructionLabel.TabIndex = 0;
			this.instructionLabel.Text = "Enter a name for the preset:";
			// 
			// responseBox
			// 
			this.responseBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.responseBox.Location = new System.Drawing.Point(63, 57);
			this.responseBox.Name = "responseBox";
			this.responseBox.Size = new System.Drawing.Size(335, 20);
			this.responseBox.TabIndex = 1;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(313, 94);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(85, 30);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(222, 94);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(85, 30);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "Ok";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// SavePresetDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(414, 140);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.responseBox);
			this.Controls.Add(this.instructionLabel);
			this.Controls.Add(this.iconImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SavePresetDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Save Preset As";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SavePresetDialog_FormClosed);
			this.Load += new System.EventHandler(this.SavePresetDialog_Load);
			this.Shown += new System.EventHandler(this.SavePresetDialog_Shown);
			((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox iconImage;
		private System.Windows.Forms.Label instructionLabel;
		private System.Windows.Forms.TextBox responseBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
	}
}