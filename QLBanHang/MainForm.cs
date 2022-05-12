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
		private List<DiningTable> _tableList;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Show();
			LoginForm dlg = new LoginForm();
			if (dlg.ShowDialog() != DialogResult.OK)
			{
				Application.Exit();
				return;
			}

			var currentUser = WorkingContext.CurrentUser;
			tsslLogin.Text = currentUser.FullName;
			tsslCurrentRole.Text = currentUser.RoleType == 0 ? "Quản lý" : "Nhân viên";

			if (currentUser.RoleType == 0)
				tsmiAdminForm.Enabled = true;

			_tableList = WorkingContext.TableList;
			LoadTableList();

		}

		
		private void tsmiAdminForm_Click(object sender, EventArgs e)
		{
			var adminDlg = new AdminForm();
			adminDlg.ShowDialog();
		}

		private void tsmiLogout_Click(object sender, EventArgs e)
		{
			tsslCurrentRole.Text = "";
			tsslLogin.Text = "";
			tsmiAdminForm.Enabled = false;

			MainForm_Load(this, null);
		}

		private void LoadTableList()
		{
			ListViewGroup floorOne = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
			ListViewGroup floorTwo = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
			ListViewGroup floorThree = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);
			lvTable.Groups.Add(floorOne);
			lvTable.Groups.Add(floorTwo);
			lvTable.Groups.Add(floorThree);
			var floorGroups = new[] { floorOne, floorTwo, floorThree };
			foreach (var table in _tableList)
			{
				ListViewItem item = new ListViewItem(table.TableName, table.Status);
				item.Group = floorGroups[table.Floor - 1];
				lvTable.Items.Add(item);
			}


			var node1 = tvTableList.Nodes.Add("Floor1","Tầng 1",3);
			var node2 = tvTableList.Nodes.Add("Floor1", "Tầng 2",3);
			var node3 = tvTableList.Nodes.Add("Floor1", "Tầng 3",3);
			var nodes = new[] {node1, node2, node3};
			foreach (var diningTable in _tableList)
			{
				nodes[diningTable.Floor - 1].Nodes.Add(diningTable.TableName, diningTable.TableName, diningTable.Status);
			}
			tvTableList.ExpandAll();
		}
	}
}
