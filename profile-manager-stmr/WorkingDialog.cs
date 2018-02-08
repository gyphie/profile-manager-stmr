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

		public void ShowWorking(string message = "Working...")
		{
			this.lblWorkingMessage.Text = message;
			this.StartPosition = FormStartPosition.CenterParent;
			this.startTime = DateTime.Now;
			this.ShowDialog();
		}

		public void HideWorking(int minMillisecondsDisplayed = 3000)
		{

			var timeElapsed = TimeSpan.MinValue;
			do
			{
				timeElapsed = DateTime.Now - this.startTime;
				Application.DoEvents();
				Thread.Sleep(10);
			}
			while (timeElapsed.TotalMilliseconds < minMillisecondsDisplayed);

			this.Close();
		}
	}
}
