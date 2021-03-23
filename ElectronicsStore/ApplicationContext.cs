using Shop_MVVM_db.Command;
using Shop_MVVM_db.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shop_MVVM_db
{
	internal class ApplicationContext:DbContext 
	 {
		public DbSet<Phone> Phones { get; set; }
		public DbSet<Laptop> Laptops { get; set; }
		public DbSet<TV> TVS { get; set; }
		public ApplicationContext() : base("DefaultConnection")
		{
			Phones.Load();
			Laptops.Load();
			//TVS.Load();
		}
		
		public void Save() { this.SaveChanges(); }
	}
}
