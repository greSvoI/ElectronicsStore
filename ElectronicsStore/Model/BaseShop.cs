using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectronicsStore.Model
{
   public  class BaseShop:DbContext
    {
		public DbSet<Phone> Phones { get; set; }
		public DbSet<Laptop> Laptops { get; set; }
		public DbSet<TV> TVs { get; set; }
		public BaseShop() : base("DefaultConnection")
		{
			
			Phones.Load();
			Laptops.Load();
			TVs.Load();
		}
		public void AddItem()
        {
			Object temp = new object();
			foreach (Window window in Application.Current.Windows)
			{
				if (window.GetType() == typeof(MainWindow))
				{
					temp = (window as MainWindow).listboxItems.ItemsSource;
				}
			}
			if (temp != null)
			{
				WindowAddEdit window = new WindowAddEdit();
				if (window.ShowDialog() == true)
				{
					
					if (temp is IEnumerable<Phone>)
					{
						Phones.Add((Phone)new Phone().ShopToItem(window.view.OtherElectronics));
					}
					else if (temp is IEnumerable<Laptop>)
					{
						Laptops.Add((Laptop)new Laptop().ShopToItem(window.view.OtherElectronics));
					}
					else if (temp is IEnumerable<TV>)
					{
						TVs.Add((TV)new TV().ShopToItem(window.view.OtherElectronics));
					}
				SaveChanges();
				}

			}
		}
		public void DelItem()
        {
			Object temp = new object();
			foreach (Window window in Application.Current.Windows)
            {
				if(window.GetType() == typeof(MainWindow))
                {
					 temp = (window as MainWindow).listboxItems.SelectedItem;
                }
            }
			
			if(temp!=null)
            {
					if (temp is Phone)

					Phones.Remove((Phone)temp);

					else if (temp is Laptop)

					Laptops.Remove((Laptop)temp);

					else if (temp is TV)

					TVs.Remove((TV)temp);

				SaveChanges();
				
			}
        }
	}
}
