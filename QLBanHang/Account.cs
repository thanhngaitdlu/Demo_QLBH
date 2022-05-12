using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
	public class Account
	{
		private string _password;
		public int Id { get; set; }
		public string LoginName { get; set; }

		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				var sha1 = new SHA1CryptoServiceProvider();
				var data = Encoding.ASCII.GetBytes(value);
				var shaData = sha1.ComputeHash(data);
				_password = Encoding.ASCII.GetString(shaData);
				
			}
		}

		public string  FullName { get; set; }

		public string  SoCCCD { get; set; }

		public string SoDienThoai { get; set; }

		public string DiaChi { get; set; }

		public int  RoleType { get; set; }

		public bool IsActive { get; set; }

		public Account(int id, string loginName, string password, string fullName, string soCccd, string soDienThoai, string diaChi, int roleType, bool isActive)
		{
			Id = id;
			LoginName = loginName;
			Password = password;
			FullName = fullName;
			SoCCCD = soCccd;
			SoDienThoai = soDienThoai;
			DiaChi = diaChi;
			RoleType = roleType;
			IsActive = isActive;
		}
	}
}
