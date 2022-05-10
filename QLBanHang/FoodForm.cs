using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
	public partial class FoodForm : Form
	{
		private int _foodId;

		public Food ReturnedFood { get; private set; }

		public FoodForm(int foodId = 0)
		{
			InitializeComponent();

			_foodId = foodId;
		}

		private void FoodForm_Load(object sender, EventArgs e)
		{
			LoadDataToCategoryComboBox();
			if (_foodId > 0)
			{
				var food = WorkingContext.FoodList.FirstOrDefault(f => f.Id == _foodId);
				ShowFoodInformation(food);
			}
		}

		private void ShowFoodInformation(Food food)
		{
			if (food == null) return;

			txtFoodId.Text = food.Id.ToString();
			txtFoodName.Text = food.Name;
			txtUnit.Text = food.Unit;
			nudUnitPrice.Value = food.UnitPrice;
			txtImageLink.Text = food.ImageLink;
			cbbCategory.SelectedValue = food.CategoryId;
			txtDescription.Text = food.Description;
			//txtImageLink.Text = food.ImageLink;

			if (!string.IsNullOrWhiteSpace(food.ImageLink) && File.Exists(food.ImageLink))
			{
				txtImageLink.Text = food.ImageLink;
				ptbFoodImage.Load(food.ImageLink);
			}
		}

		private void LoadDataToCategoryComboBox()
		{
			var list = WorkingContext.CategoryList;
			cbbCategory.DataSource = list;

			cbbCategory.DisplayMember = "Name";
			cbbCategory.ValueMember = "Id";
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select Picture";// "Add Photos";
			dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
			             + "*.jpg;*.jpeg;*.gif;*.bmp;"
			             + "*.tif;*.tiff;*.png|"
			             + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
			             + "GIF files (*.gif)|*.gif|"
			             + "BMP files (*.bmp)|*.bmp|"
			             + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
			             + "PNG files (*.png)|*.png|"
			             + "All files (*.*)|*.*";
			dlg.InitialDirectory = Environment.CurrentDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var fileName = dlg.FileName;
				txtImageLink.Text = fileName;
				ptbFoodImage.Load(fileName);
			}
		}

		private void btnSaveFood_Click(object sender, EventArgs e)
		{
			var name = txtFoodName.Text;
			var unit = txtUnit.Text;
			var description = txtDescription.Text;
			var link = txtImageLink.Text;
			var price = Convert.ToInt32(nudUnitPrice.Value);
			var categoryId = Convert.ToInt32(cbbCategory.SelectedValue);
			var nhacc = cbbNhaCC.SelectedItem.ToString();

			if (_foodId == 0)
			{
				var id = WorkingContext.FoodList.Any() ? WorkingContext.FoodList.Max(f => f.Id) + 1 : 1;
				ReturnedFood = new Food(id, name, unit, price, description, link, categoryId, nhacc);
				WorkingContext.FoodList.Add(ReturnedFood);
			}
			else
			{
				ReturnedFood = WorkingContext.FoodList.FirstOrDefault(f => f.Id == _foodId);
				if (ReturnedFood != null)
				{
					ReturnedFood.Name = name;
					ReturnedFood.Unit = unit;
					ReturnedFood.Description = description;
					ReturnedFood.ImageLink = link;
					ReturnedFood.CategoryId = categoryId;
					ReturnedFood.UnitPrice = price;
					ReturnedFood.NhaCungCap = nhacc;
				}
				else
				{
					MessageBox.Show($"Không tìm thấy món ăn có mã {_foodId}", "Thông báo");
					return;
				}
			}
			DialogResult = DialogResult.OK;
		}
	}
}
