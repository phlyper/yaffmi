using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Yaffmi
{
	public partial class AboutDialog : Form
	{
		readonly ContextMenu rightClickMenu;

		public AboutDialog()
		{
			InitializeComponent();

			versionLabel.Text = Settings.Version;

			licenseLink.Links.Add(0, 21,
				@"http://www.gnu.org/licenses/gpl.txt");

			ffmpegLink.Links.Add(12, 6,
				@"http://ffmpeg.org/index.html");
			ffmpegLink.Links.Add(84, 7,
				@"http://ffmpeg.zeranoe.com/builds/");
			iconsLink.Links.Add(34, 6,
				@"http://www.fatcow.com/free-icons");
			cactusLink.Links.Add(31, 5,
				@"http://openclipart.org/user-detail/DooFi");
			helpLink.Links.Add(43, 23,
				@"mailto:yaffmi@electroworks.net");

			rightClickMenu = new ContextMenu(
				new [] { new MenuItem("Copy URL", copyURL_Click) });
		}

		void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = (string)e.Link.LinkData;

			if (e.Button == MouseButtons.Left)
			{
				try { Process.Start(url); }
				catch
				{
					MessageBox.Show(this,
						String.Format("Could not open \"{0}\".", url), 
						"URL Launch Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (e.Button == MouseButtons.Right)
			{
				rightClickMenu.Tag = url;
				rightClickMenu.Show(this, PointToClient(Cursor.Position));
			}
		}

		void copyURL_Click(object sender, EventArgs e)
		{
			Clipboard.SetText((string)rightClickMenu.Tag);
		}
	}
}
