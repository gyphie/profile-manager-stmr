using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net.glympz.ProfileManagerSTMR.Business;
using net.glympz.ProfileManagerSTMR.Properties;
using SharpCompress.Readers;
using Syroot.Windows.IO;

namespace net.glympz.ProfileManagerSTMR
{
	public partial class frmInstallMod : Form
	{
		private OpenFileDialog modFilePicker;
		private string modFolderPath;
		private frmWorkingDialog workingDialog;
		public frmInstallMod()
		{
			InitializeComponent();
			this.Icon = Resources.ProfileManagerIcon;
		}

		public DialogResult ShowForm(IWin32Window owner, string modFolderPath)
		{
			this.modFolderPath = modFolderPath;
			return this.ShowDialog(owner);
		}

		private void frmInstallMod_Load(object sender, EventArgs e)
		{
			this.workingDialog = new frmWorkingDialog();
			this.txtModFilePath.ReadOnly = true;
			this.txtModFilePath.Text = "";
			this.txtModName.Text = "";
			this.SetupFilePicker();
		}

		private void SetupFilePicker()
		{
			this.modFilePicker = new OpenFileDialog();
			this.modFilePicker.RestoreDirectory = false;
			this.modFilePicker.Title = "Install a Spintires: MudRunner Mod";
			this.modFilePicker.Multiselect = false;

			string initDir = KnownFolders.Downloads.ExpandedPath;
			if (!Directory.Exists(initDir)) initDir = KnownFolders.Profile.ExpandedPath;
			this.modFilePicker.InitialDirectory = initDir;
			this.modFilePicker.Filter = "Mod archive (*.zip;*.rar;*.7z)|*.ZIP;*.RAR;*.7Z|All files (*.*)|*.*";
			this.modFilePicker.CheckFileExists = true;

		}

		private void btnSteamFolderPicker_Click(object sender, EventArgs e)
		{

			if (this.modFilePicker.ShowDialog() == DialogResult.OK)
			{
				this.txtModFilePath.Text = this.modFilePicker.FileName;
			}

			if (string.IsNullOrWhiteSpace(this.txtModName.Text))
			{
				this.txtModName.Text = Path.GetFileNameWithoutExtension(this.txtModFilePath.Text);
			}
		}

		private void DecompressArchive(string archivePath, string targetPath)
		{
			SharpCompress.Archives.ArchiveFactory.WriteToDirectory(
				archivePath,
				targetPath,
				new ExtractionOptions() {
					Overwrite = false,
					PreserveFileTime = true,
					ExtractFullPath = true
				}
			);
		}

		private void bgwInstaller_DoWork(object sender, DoWorkEventArgs e)
		{
			WorkerData workerData = e.Argument as WorkerData;
			try
			{
				e.Result = workerData;
				this.DecompressArchive(workerData.ArchivePath, workerData.ModPath);
			}
			catch (Exception ex)
			{
				throw new BackgroundWorkerRunException("Exception thrown in DoWork", workerData, ex);
			}
		}

		private void bgwInstaller_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Enabled = true;

			if (e.Error != null)
			{
				var bgwException = e.Error as BackgroundWorkerRunException;
				var innerException = bgwException.InnerException;

				if (bgwException.WorkerData != null && Directory.Exists(bgwException.WorkerData.ModPath))
				{
					try
					{
						Directory.Delete(bgwException.WorkerData.ModPath, true);
					}
					catch { }
				}

				if (innerException is UnauthorizedAccessException)
				{
					MessageBox.Show("The mod could not be installed. You may need to run as administrator.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("There was an unexpected error and the mod could not be installed.", "Mod installation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				return;
			}

			this.workingDialog.HideWorking();
			this.DialogResult = DialogResult.OK;
		}

		private void btnInstall_Click(object sender, EventArgs e)
		{
			if (this.bgwInstaller.IsBusy) return;


			string modPath = AppLogic.PathCombine(this.modFolderPath, this.txtModName.Text);

			if (Directory.Exists(modPath))
			{
				MessageBox.Show("A mod with this name already exists. Please choose a different name.", "Mod already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				Directory.CreateDirectory(modPath);
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("The mod folder could not be created. You may need to run as administrator.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch (Exception ex) when (ex is IOException || ex is ArgumentException || ex is ArgumentNullException || ex is PathTooLongException)
			{
				MessageBox.Show("The mod folder could not created. Make sure the mod name does contain invalid characters.", "Folder creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch
			{
				MessageBox.Show("The mod folder could not created.", "Folder creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.Enabled = false;
			this.bgwInstaller.RunWorkerAsync(new WorkerData { ArchivePath = this.txtModFilePath.Text, ModPath = modPath });
			this.workingDialog.ShowWorking("Installing mod...");
		}

		private class WorkerData
		{
			public string ArchivePath { get; set; }
			public string ModPath { get; set; }
		}

		private class BackgroundWorkerRunException : Exception
		{
			public WorkerData WorkerData { get; set; }
			public BackgroundWorkerRunException(string message, WorkerData workerData, Exception innerException) : base(message, innerException)
			{
				this.WorkerData = workerData;
			}
		}
	}
}
