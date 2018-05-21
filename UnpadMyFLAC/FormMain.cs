using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace UnpadMyFLAC
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		/*String	directory:		full path to the file, not including the filename			Eg.		"C:\foo\bar.txt"
					fileEntries:	full path to a list of files, including the filenames		Eg.	[0]	"C:\latin\lorem.txt"
																									[1]	"C:\latin\ipsum.txt"
					file:			a single position of the array "fileEntries"				Eg.	[1]	"C:\latin\ipsum.txt"
					fileName:		the filename of "file", including extension					Eg.		"ipsum.txt"*/


		private void buttonOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Any file|*.*",
				Title = "Select a file from a folder you want to remove FLAC padding"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				String		directory	= Path.GetDirectoryName(openFileDialog.FileName);
				String[]	fileEntries = Directory.GetFiles(directory);
				foreach (String file in fileEntries)
				{
					Process process = new Process();
					process.StartInfo.UseShellExecute = true;
					process.StartInfo.RedirectStandardOutput = false;
					process.StartInfo.RedirectStandardOutput = false;
					process.StartInfo.FileName = "metaflac.exe";
					process.StartInfo.Arguments = String.Concat("--remove --block-type=PADDING --dont-use-padding \"", file, '\"');

					process.Start();
				}
			}
		}

		private void btnOpenAllFolders_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				Description = "Select a file from a folder and subfolders you want to remove FLAC padding",
				ShowNewFolderButton = false
			};

			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				String		directory		= folderBrowserDialog.SelectedPath;
				String[]	fileEntries		= Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
				foreach (String file in fileEntries)
				{
					Process process = new Process();
					process.StartInfo.UseShellExecute = true;
					process.StartInfo.RedirectStandardOutput = false;
					process.StartInfo.RedirectStandardOutput = false;
					process.StartInfo.FileName = "metaflac.exe";
					process.StartInfo.Arguments = String.Concat("--remove --block-type=PADDING --dont-use-padding \"", file, '\"');

					process.Start();
					process.WaitForExit(60 * 1000);
				}
			}
		}
	}
}
