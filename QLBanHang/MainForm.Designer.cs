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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiAdminForm = new System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslLogin = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslCurrentRole = new System.Windows.Forms.ToolStripStatusLabel();
			this.lvTable = new System.Windows.Forms.ListView();
			this.tableImageList = new System.Windows.Forms.ImageList(this.components);
			this.tvTableList = new System.Windows.Forms.TreeView();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdminForm,
            this.tàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(972, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiAdminForm
			// 
			this.tsmiAdminForm.Enabled = false;
			this.tsmiAdminForm.Name = "tsmiAdminForm";
			this.tsmiAdminForm.Size = new System.Drawing.Size(110, 24);
			this.tsmiAdminForm.Text = "Trang quản lý";
			this.tsmiAdminForm.Click += new System.EventHandler(this.tsmiAdminForm_Click);
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.tsmiLogout});
			this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
			// 
			// cậpNhậtThôngTinToolStripMenuItem
			// 
			this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
			this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
			this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
			// 
			// tsmiLogout
			// 
			this.tsmiLogout.Name = "tsmiLogout";
			this.tsmiLogout.Size = new System.Drawing.Size(207, 26);
			this.tsmiLogout.Text = "Đăng xuất";
			this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLoginName,
            this.tsslLogin,
            this.tsslRole,
            this.tsslCurrentRole});
			this.statusStrip1.Location = new System.Drawing.Point(0, 626);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(972, 25);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslLoginName
			// 
			this.tsslLoginName.Name = "tsslLoginName";
			this.tsslLoginName.Size = new System.Drawing.Size(153, 20);
			this.tsslLoginName.Text = "Tài khoản đăng nhập: ";
			// 
			// tsslRole
			// 
			this.tsslRole.Name = "tsslRole";
			this.tsslRole.Size = new System.Drawing.Size(59, 20);
			this.tsslRole.Text = "Vai trò: ";
			// 
			// tsslLogin
			// 
			this.tsslLogin.Name = "tsslLogin";
			this.tsslLogin.Size = new System.Drawing.Size(12, 20);
			this.tsslLogin.Text = ".";
			// 
			// tsslCurrentRole
			// 
			this.tsslCurrentRole.Name = "tsslCurrentRole";
			this.tsslCurrentRole.Size = new System.Drawing.Size(12, 20);
			this.tsslCurrentRole.Text = ".";
			// 
			// lvTable
			// 
			this.lvTable.LargeImageList = this.tableImageList;
			this.lvTable.Location = new System.Drawing.Point(40, 56);
			this.lvTable.Name = "lvTable";
			this.lvTable.Size = new System.Drawing.Size(487, 553);
			this.lvTable.SmallImageList = this.tableImageList;
			this.lvTable.TabIndex = 4;
			this.lvTable.UseCompatibleStateImageBehavior = false;
			// 
			// tableImageList
			// 
			this.tableImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tableImageList.ImageStream")));
			this.tableImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.tableImageList.Images.SetKeyName(0, "table_available.png");
			this.tableImageList.Images.SetKeyName(1, "table_busy.png");
			this.tableImageList.Images.SetKeyName(2, "table_reserved.png");
			this.tableImageList.Images.SetKeyName(3, "restaurant.png");
			// 
			// tvTableList
			// 
			this.tvTableList.ImageIndex = 0;
			this.tvTableList.ImageList = this.tableImageList;
			this.tvTableList.Location = new System.Drawing.Point(557, 56);
			this.tvTableList.Name = "tvTableList";
			this.tvTableList.SelectedImageIndex = 0;
			this.tvTableList.Size = new System.Drawing.Size(363, 553);
			this.tvTableList.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 651);
			this.Controls.Add(this.tvTableList);
			this.Controls.Add(this.lvTable);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý bán hàng";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdminForm;
		private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslLoginName;
		private System.Windows.Forms.ToolStripStatusLabel tsslRole;
		private System.Windows.Forms.ToolStripStatusLabel tsslLogin;
		private System.Windows.Forms.ToolStripStatusLabel tsslCurrentRole;
		private System.Windows.Forms.ListView lvTable;
		private System.Windows.Forms.ImageList tableImageList;
		private System.Windows.Forms.TreeView tvTableList;
	}
}

