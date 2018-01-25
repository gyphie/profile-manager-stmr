using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

		public void ShowWorking()
		{
			this.TopMost = true;
			this.StartPosition = FormStartPosition.CenterParent;
			this.ShowDialog();
		}
	}
}
