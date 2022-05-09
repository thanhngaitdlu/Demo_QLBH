namespace QLBanHang
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLoginName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu";
			// 
			// txtLoginName
			// 
			this.txtLoginName.Location = new System.Drawing.Point(146, 19);
			this.txtLoginName.Name = "txtLoginName";
			this.txtLoginName.Size = new System.Drawing.Size(212, 22);
			this.txtLoginName.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(146, 54);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(212, 22);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(170, 119);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(87, 32);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Đăng nhập";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(276, 119);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(81, 32);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Thoát";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(18, 81);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(12, 17);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = ".";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 173);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtLoginName);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLoginName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblMessage;
	}
}