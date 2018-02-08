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
using SharpCompress.Archives;
using SharpCompress.Readers;
using Syroot.Windows.IO;

namespace net.glympz.ProfileManagerSTMR
{
	public partial class frmInstallMod : Form
	{
		private OpenFileDialog modFilePicker;
		private string modFolderPath;
		private frmWorkingDialog workingDialog;
		private string filePickerLastUsedPath;
		public frmInstallMod()
		{
			InitializeComponent();
			this.Icon = Resources.ProfileManagerIcon;
			this.workingDialog = new frmWorkingDialog();
		}

		public DialogResult ShowForm(IWin32Window owner, string modFolderPath)
		{
			this.Tag = null;
			this.modFolderPath = modFolderPath;
			return this.ShowDialog(owner);
		}

		private void frmInstallMod_Load(object sender, EventArgs e)
		{
			this.txtModFilePath.ReadOnly = true;
			this.txtModFilePath.Text = "";
			this.txtModName.Text = "";
			this.cmboModType.SelectedIndex = 0;
			this.cmboRating.SelectedIndex = 1;
			this.SetupFilePicker();
			this.btnModArchivePicker_Click(this.btnModArchivePicker, new EventArgs());
		}

		private void SetupFilePicker()
		{
			if (this.modFilePicker == null)
			{
				this.modFilePicker = new OpenFileDialog();
				string initDir = KnownFolders.Downloads.ExpandedPath;
				if (!Directory.Exists(initDir)) initDir = KnownFolders.Profile.ExpandedPath;
				this.modFilePicker.InitialDirectory = initDir;
				this.modFilePicker.RestoreDirectory = false;
				this.modFilePicker.Title = "Install a Spintires: MudRunner Mod";
				this.modFilePicker.Multiselect = false;

				this.modFilePicker.Filter = "Mod archive (*.zip;*.rar;*.7z)|*.ZIP;*.RAR;*.7Z|All files (*.*)|*.*";
				this.modFilePicker.CheckFileExists = true;
			}

			this.modFilePicker.FileName = "";

		}

		private void btnModArchivePicker_Click(object sender, EventArgs e)
		{
			string previousModFileName = Path.GetFileNameWithoutExtension(this.txtModFilePath.Text);

			if (!string.IsNullOrEmpty(this.filePickerLastUsedPath))
			{
				this.modFilePicker.InitialDirectory = this.filePickerLastUsedPath;
			}

			if (this.modFilePicker.ShowDialog() == DialogResult.OK)
			{
				this.txtModFilePath.Text = this.modFilePicker.FileName;

				this.filePickerLastUsedPath = Path.GetDirectoryName(this.modFilePicker.FileName);
			}


			if (string.IsNullOrWhiteSpace(this.txtModName.Text) || this.txtModName.Text == previousModFileName)
			{
				this.txtModName.Text = Path.GetFileNameWithoutExtension(this.txtModFilePath.Text);
			}
		}

		private void DecompressArchive(string archivePath, string targetPath)
		{
			var options = new ExtractionOptions()
			{
				Overwrite = false,
				PreserveFileTime = true,
				ExtractFullPath = true
			};

			using (IArchive archive = SharpCompress.Archives.ArchiveFactory.Open(archivePath))
			{
				long totalEntries = archive.Entries.LongCount();
				long entryCount = 0;
				foreach (IArchiveEntry entry in archive.Entries)
				{
					entryCount++;
					entry.WriteToDirectory(targetPath, options);
					this.bgwInstaller.ReportProgress((int)((float)entryCount / (float)totalEntries * 100));
				}
			}
		}

		private void bgwInstaller_DoWork(object sender, DoWorkEventArgs e)
		{
			WorkerData workerData = e.Argument as WorkerData;
			try
			{
				e.Result = workerData;
				this.DecompressArchive(workerData.ArchivePath, AppLogic.PathCombine(workerData.GameModPath, workerData.Mod.RootPath));
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
				this.workingDialog.HideWorking(minMillisecondsDisplayed: 0);

				var bgwException = e.Error as BackgroundWorkerRunException;
				var innerException = bgwException.InnerException;

				string installationPath = AppLogic.PathCombine(bgwException.WorkerData.GameModPath, bgwException.WorkerData.Mod.RootPath);

				if (bgwException.WorkerData != null && Directory.Exists(installationPath))
				{
					try
					{
						Directory.Delete(installationPath, true);
					}
					catch { }
				}

				if (innerException is UnauthorizedAccessException)
				{
					MessageBox.Show("The mod could not be installed. You may need to run as administrator.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (innerException is InvalidOperationException && innerException.Message.StartsWith("Cannot determine compressed stream type."))
				{
					MessageBox.Show("The mod could not be installed because files compression type is not supported. You should try using 7zip or WinRar may be required.", "Unsupported file type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("There was an unexpected error and the mod could not be installed.", "Mod installation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				return;
			}
			else
			{
				WorkerData workerData = e.Result as WorkerData;

				try
				{
					workerData.Mod.Path = Mod.FindModPath(new DirectoryInfo(AppLogic.PathCombine(workerData.GameModPath, workerData.Mod.RootPath)));
					if (workerData.Mod.Type == ModType.Unknown)
					{
						workerData.Mod.Type = Mod.DetectType(AppLogic.PathCombine(workerData.GameModPath, workerData.Mod.Path), out bool multiplayer);
						workerData.Mod.Multiplayer = multiplayer;
					}
				}
				catch { }

				this.workingDialog.HideWorking();
				this.Tag = workerData.Mod;
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btnInstall_Click(object sender, EventArgs e)
		{
			if (this.bgwInstaller.IsBusy) return;

			FileInfo archiveInfo = new FileInfo(this.modFilePicker.FileName);
			string modFolder = Path.GetFileNameWithoutExtension(archiveInfo.Name);
			string modPath = AppLogic.PathCombine(this.modFolderPath, modFolder);

			if (Directory.Exists(modPath))
			{
				MessageBox.Show("A mod from this archive already exists. This mod cannot be installed.", "Mod already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				MessageBox.Show("The mod folder could not created. Make sure the mod name does not contain invalid characters.", "Folder creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch
			{
				MessageBox.Show("The mod folder could not created.", "Folder creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var mod = new Mod
			{
				Name = this.txtModName.Text,
				Type = Enums.StringToModType(this.cmboModType.SelectedItem.ToString()),
				Rating = Enums.StringToRating(this.cmboRating.SelectedItem.ToString()),
				InstallationDate = DateTime.Now,
				RootPath = modFolder
			};

			this.bgwInstaller.RunWorkerAsync(new WorkerData { ArchivePath = this.txtModFilePath.Text, Mod = mod, GameModPath = this.modFolderPath });
			this.workingDialog.ShowWorking("Installing mod...", hasProgress: true);
		}

		private class WorkerData
		{
			public string ArchivePath { get; set; }
			public Mod Mod { get; set; }
			public string GameModPath { get; set; }
		}

		private class BackgroundWorkerRunException : Exception
		{
			public WorkerData WorkerData { get; set; }
			public BackgroundWorkerRunException(string message, WorkerData workerData, Exception innerException) : base(message, innerException)
			{
				this.WorkerData = workerData;
			}
		}

		private void bgwInstaller_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.workingDialog.SetProgress(e.ProgressPercentage);
		}
	}
}
