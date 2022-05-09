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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var username = txtLoginName.Text;
			var passWord = txtPassword.Text;
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passWord))
			{
				MessageBox.Show("Vui lòng nhập thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (username.CompareTo("a") != 0 && passWord.CompareTo("1") != 0)
			{
				lblMessage.Text = "Sai tên đăng nhập và mật khẩu.";
			}
			else
			{
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
