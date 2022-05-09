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
	public partial class FoodForm : Form
	{
		public FoodForm()
		{
			InitializeComponent();
		}

		private void FoodForm_Load(object sender, EventArgs e)
		{
			LoadDataToCategoryComboBox();
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
	}
}
