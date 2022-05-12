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
	public partial class AdminForm : Form
	{
		private const string NhapTenDM = "---Nhập tên danh mục --";
		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			SetInputCategoryText();
			LoadCategoryList(WorkingContext.CategoryList);
			LoadFoodList(WorkingContext.FoodList);
			LoadAccountList(WorkingContext.AccountList);
		}

		private void LoadCategoryList(List<Category> list)
		{
			flpDsLoaiMatHang.Controls.Clear();
			foreach (var category in list)
			{
				var btn = new Button();
				btn.Text = category.Name;
				btn.Size = new Size(205, 30);
				btn.BackColor = Color.Aquamarine;
				btn.Tag = category.Id;
				btn.Click += CategoryButton_Click;

				flpDsLoaiMatHang.Controls.Add(btn);
			}

			lblCategoryNum.Text = list.Count.ToString();
		}

		private void CategoryButton_Click(object sender, EventArgs e)
		{
			var id = int.Parse((sender as Button).Tag.ToString());

			var list = WorkingContext.FoodList.Where(f => f.CategoryId == id).ToList();
			LoadFoodList(list);
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{

		}

		private void SetInputCategoryText()
		{
			txtTenLoai.Text = NhapTenDM;
			txtTenLoai.GotFocus += TxtTenLoaiOnGotFocus;
			txtTenLoai.LostFocus += TxtTenLoaiOnLostFocus;
		}

		private void TxtTenLoaiOnLostFocus(object sender, EventArgs e)
		{
			txtTenLoai.Text = NhapTenDM;
			LoadCategoryList(WorkingContext.CategoryList);
		}

		private void TxtTenLoaiOnGotFocus(object sender, EventArgs e)
		{
			txtTenLoai.Text = "";
		}

		private void txtTenLoai_TextChanged(object sender, EventArgs e)
		{
			var ten = txtTenLoai.Text;
			var list = WorkingContext.CategoryList.Where(c => c.Name.ToLower().Contains(ten)).ToList();
			LoadCategoryList(list);
		}

		private void btnAddFood_MouseHover(object sender, EventArgs e)
		{
			btnAddFood.BackColor = Color.Aqua;
		}

		private void LoadFoodList(List<Food> list)
		{
			lvDsMonAn.Items.Clear();
			foreach (var food in list)
			{
				AddFoodToLV(food);
			}
			lblFoodNum.Text = list.Count.ToString();
		}

		private void AddFoodToLV(Food f)
		{
			var item = new ListViewItem(f.Id.ToString());
			item.SubItems.Add(f.Name);
			item.SubItems.Add(f.Unit);
			item.SubItems.Add(f.UnitPrice.ToString());
			item.SubItems.Add(f.CategoryId.ToString());
			item.SubItems.Add(f.NhaCungCap);
			item.SubItems.Add(f.Description);
			item.SubItems.Add(f.ImageLink);

			lvDsMonAn.Items.Add(item);
		}

		private void LoadAccountList(List<Account> list)
		{
			lvAccountList.Items.Clear();
			foreach (var account in list)
			{
				AddAccountToLV(account);
			}
			lblFoodNum.Text = list.Count.ToString();
		}

		private void AddAccountToLV(Account acc)
		{
			var item = new ListViewItem(acc.Id.ToString());
			item.SubItems.Add(acc.LoginName);
			item.SubItems.Add(acc.FullName);
			item.SubItems.Add(acc.SoCCCD);
			item.SubItems.Add(acc.SoDienThoai);
			item.SubItems.Add(acc.DiaChi);
			item.SubItems.Add(acc.RoleType == 0 ? "Quản lý" : "Nhân viên");
			item.SubItems.Add(acc.IsActive ? "Đang hoạt động" : "Đã xóa");
			item.SubItems.Add(acc.Password);

			lvAccountList.Items.Add(item);
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			var foodDlg = new FoodForm();
			if (foodDlg.ShowDialog() == DialogResult.OK)
			{
				var food = foodDlg.ReturnedFood;
				AddFoodToLV(food);
			}
		}

		private void lvDsMonAn_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lvDsMonAn_DoubleClick(object sender, EventArgs e)
		{
			if (lvDsMonAn.SelectedItems.Count == 0) return;

			var item = lvDsMonAn.SelectedItems[0];
			var foodId = Convert.ToInt32(item.Text);

			var dialog = new FoodForm(foodId);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var food = dialog.ReturnedFood;
				item.SubItems[1].Text = food.Name;
				item.SubItems[2].Text = food.Unit;
				item.SubItems[3].Text = food.UnitPrice.ToString();
				item.SubItems[4].Text = food.CategoryId.ToString();
				item.SubItems[5].Text = food.Description;
				item.SubItems[6].Text = food.ImageLink;
			}
		}

		private void cbbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
		{
			var nhacc = cbbNhaCC.SelectedItem.ToString();

			var list = WorkingContext.FoodList.Where(f => f.NhaCungCap.Contains(nhacc)).ToList();
			LoadFoodList(list);
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			if (lvDsMonAn.SelectedItems.Count > 0)
			{
				var list = WorkingContext.FoodList;
				foreach (ListViewItem item in lvDsMonAn.SelectedItems)
				{
					var id = int.Parse(item.Text);
					list.RemoveAll(f => f.Id == id);
				}
				LoadFoodList(list);
			}
		}
	}
}
