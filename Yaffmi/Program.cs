using System;
using System.Windows.Forms;

namespace Yaffmi
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			try { Settings.Load(); }
			catch (SettingsException)
			{
				MessageBox.Show(
					String.Format("Could not load \"{0}\".", Settings.SettingsFile), 
					"Settings Load Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
