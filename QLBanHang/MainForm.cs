using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Show();
			LoginForm dlg = new LoginForm();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				lblMessage.Text = "Bạn đã đăng nhập";
			}
			
		}

		private void btnAdminForm_Click(object sender, EventArgs e)
		{
			var adminDlg = new AdminForm();
			adminDlg.ShowDialog();
		}
	}
}
