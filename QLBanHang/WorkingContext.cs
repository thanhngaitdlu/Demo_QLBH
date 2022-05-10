using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
	public static class WorkingContext
	{
		public static string UserName { get; set; }

		public static string Password { get; set; }

		

		public static List<Category> CategoryList { get; set; }

		public static List<Food> FoodList { get; set; }

		static WorkingContext()
		{
			
			CategoryList = CreateDataCategoryList();
			FoodList = CreateDataFoodList();
		}

		
		private static List<Category> CreateDataCategoryList()
		{
			var catNames = new[] { "Hải sản", "Lẩu", "Rau", "Gà", "Khai vị", "Bò", "Đặc biệt", "Nước ngọt", "Bia" };

			return catNames
				.Select((name, idx) => new Category()
				{
					Id = idx + 1,
					Name = name
				})
				.ToList();

		}

		private static List<Food> CreateDataFoodList()
		{
			return new List<Food>()
			{
				new Food(1, "Gỏi thập cẩm", "Dĩa", 45000, "", "", 5, "Bếp 1"),
				new Food(2, "Gỏi gà", "Dĩa", 45000, "", "", 5, "Bếp 2"),
				new Food(3, "Gỏi Thái Lan", "Dĩa", 45000, "", "", 5, "Bếp 3"),
				new Food(4, "Tôm nướng muối ớt", "Kg", 300000, "", "", 1, "Bếp 1"),
				new Food(5, "Mực nướng muối ớt", "Kg", 355000, "", "", 1, "Bếp 1"),
				new Food(6, "Sò lông nướng mỡ hành", "Dĩa", 120000, "", "", 1, "Bếp 2"),
				new Food(7, "Lẩu hải sản", "Cái", 250000, "", "", 2, "Bếp 2"),
				new Food(8, "Lẩu thái", "Cái", 250000, "", "", 2, "Bếp 3"),
				new Food(9, "Rau muống xào tỏi", "Dĩa", 40000, "", "", 3, "Bếp 3"),
				new Food(10, "Gà hấp hành", "Dĩa", 200000, "", "", 4, "Bếp 2")
			};
		}
	}
}
