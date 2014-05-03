using System;
using System.Drawing;
using System.Windows.Forms;

namespace Yaffmi
{
	public partial class SavePresetDialog : Form
	{
		public string PresetName { get; set; }

		public SavePresetDialog()
		{
			InitializeComponent();
			iconImage.Image = SystemIcons.Question.ToBitmap();

			PresetName = "";
		}

		void SavePresetDialog_Load(object sender, EventArgs e)
		{
			responseBox.Text = PresetName;
		}

		void SavePresetDialog_Shown(object sender, EventArgs e)
		{
			responseBox.Focus();
		}

		void SavePresetDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			PresetName = responseBox.Text;
		}
	}
}
