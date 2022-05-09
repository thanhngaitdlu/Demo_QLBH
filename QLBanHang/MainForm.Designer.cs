namespace QLBanHang
{
	partial class MainForm
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
			this.btnAdminForm = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAdminForm
			// 
			this.btnAdminForm.Location = new System.Drawing.Point(301, 92);
			this.btnAdminForm.Name = "btnAdminForm";
			this.btnAdminForm.Size = new System.Drawing.Size(75, 23);
			this.btnAdminForm.TabIndex = 0;
			this.btnAdminForm.Text = "Quản lý";
			this.btnAdminForm.UseVisualStyleBackColor = true;
			this.btnAdminForm.Click += new System.EventHandler(this.btnAdminForm_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.SeaGreen;
			this.lblMessage.Location = new System.Drawing.Point(30, 513);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(46, 17);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnAdminForm);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý bán hàng";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdminForm;
		private System.Windows.Forms.Label lblMessage;
	}
}

