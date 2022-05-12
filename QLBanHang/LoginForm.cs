using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

			var account = WorkingContext.AccountList.FirstOrDefault(acc => acc.LoginName == username);

			if (account != null)
			{
				var sha1 = new SHA1CryptoServiceProvider();
				var data = Encoding.ASCII.GetBytes(passWord);
				var shaData = sha1.ComputeHash(data);
				var hashedPassword = Encoding.ASCII.GetString(shaData);
				if (account.Password.CompareTo(hashedPassword) == 0)
				{
					WorkingContext.CurrentUser = account;
					WorkingContext.Password = hashedPassword;
					this.DialogResult = DialogResult.OK;
				}
					
				else
				{
					MessageBox.Show("Mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Không tồn tại tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
