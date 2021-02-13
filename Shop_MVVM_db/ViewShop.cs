using Shop_MVVM_db.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_MVVM_db
{
	class ViewShop: DbContext
	{
		public DbSet<Phone> Phones { get; set; }
		public DbSet<Laptop> Laptops { get; set; }
		public DbSet<TV> TVS { get; set; }
		public ViewShop():base("DefaultConnection")
		{
			Phones.Load();
			Laptops.Load();
			TVS.Load();
		}
	}
}
