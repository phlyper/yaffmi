using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Yaffmi
{
	partial class MainWindow
	{
		class InputFile
		{
			public string FilePath { get; private set; }
			public string FileName { get; private set; }

			public InputFile(string filePath)
			{
				FilePath = filePath;
				FileName = Path.GetFileName(filePath);
			}

			public override string ToString()
			{
				return
					(Settings.ShowFullInputFilePath) ?
					FilePath :
					FileName;
			}
		}

		void addItemButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Title = "Add item", 
				Multiselect = true,
			};

			fileListBox.BeginUpdate();
			if (dialog.ShowDialog(this) == DialogResult.OK)
				fileListBox.Items.AddRange(
					dialog.FileNames
					.Select(path => new InputFile(path))
					.ToArray());
			fileListBox.EndUpdate();
		}

		void removeItemButton_Click(object sender, EventArgs e)
		{
			object[] selectedItems =
				fileListBox.SelectedItems
				.Cast<object>()
				.ToArray();

			fileListBox.BeginUpdate();
			foreach (object item in selectedItems)
				fileListBox.Items.Remove(item);
			fileListBox.EndUpdate();
		}

		void clearListButton_Click(object sender, EventArgs e)
		{
			fileListBox.BeginUpdate();
			fileListBox.Items.Clear();
			fileListBox.EndUpdate();
		}

		void fileListBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect =
				(e.Data.GetDataPresent(DataFormats.FileDrop)) ?
				DragDropEffects.Copy :
				DragDropEffects.None;
		}

		void fileListBox_DragDrop(object sender, DragEventArgs e)
		{
			fileListBox.BeginUpdate();
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				fileListBox.Items.AddRange(
					((string[])e.Data.GetData(DataFormats.FileDrop))
					.Select(path => new InputFile(path))
					.ToArray());
			fileListBox.EndUpdate();
		}
	}
}
