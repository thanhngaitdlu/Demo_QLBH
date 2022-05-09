using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
	public class Food
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Unit { get; set; }

		public int UnitPrice { get; set; }

		public string Description { get; set; }

		public string ImageLink { get; set; }

		public int CategoryId { get; set; }

		public Food()
		{

		}

		public Food(int id, string name, string unit, int unitPrice, string description, string imageLink, int categoryId)
		{
			Id = id;
			Name = name;
			Unit = unit;
			UnitPrice = unitPrice;
			Description = description;
			ImageLink = imageLink;
			CategoryId = categoryId;
		}
	}
}
