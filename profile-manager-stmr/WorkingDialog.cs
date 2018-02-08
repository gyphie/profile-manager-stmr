using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net.glympz.ProfileManagerSTMR
{
	public partial class frmWorkingDialog : Form
	{
		public frmWorkingDialog()
		{
			InitializeComponent();
		}

		private DateTime startTime;
		private int minMillisecondsDisplayed = 0;

		public void ShowWorking(string message = "Working...", bool hasProgress = false)
		{
			this.timHide.Stop();
			this.lblWorkingMessage.Text = message;
			this.StartPosition = FormStartPosition.CenterParent;
			this.startTime = DateTime.Now;

			this.progressBar.Style = hasProgress ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;
			this.progressBar.Value = 0;

			this.minMillisecondsDisplayed = 0;
			this.ShowDialog();
		}

		public void HideWorking(int minMillisecondsDisplayed = 2000)
		{
			if (this.progressBar.Style != ProgressBarStyle.Marquee)
			{
				this.progressBar.Value = 100;	// We want the dialog to stay visible long enough for the user to register the change in progress.
				this.startTime = DateTime.Now;
			}

			this.minMillisecondsDisplayed = minMillisecondsDisplayed;
			this.timHide.Start();
		}

		public void SetProgress(int percentComplete)
		{
			percentComplete = Math.Max(0, Math.Min(100, percentComplete));
			this.progressBar.Value = percentComplete;
		}

		private void timHide_Tick(object sender, EventArgs e)
		{
			var timeElapsed = DateTime.Now - this.startTime;

			if (timeElapsed.TotalMilliseconds >= minMillisecondsDisplayed)
			{
				this.timHide.Stop();
				this.Close();
			}
		}
	}
}
