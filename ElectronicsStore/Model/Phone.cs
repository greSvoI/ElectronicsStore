using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore.Model
{
    public class Phone:IShop
    {
		string title;
		double price;
		string company;
		string description;

		public int id { get; set; }
		public string Title { get => title; set => title = value; }
		public double Price { get => price; set => price = value; }
		public string Company { get => company; set => company = value; }
		public string Description { get => description; set => description = value; }

        public IShop ShopToItem(VariousElectronics other)
        {
			Phone phone = new Phone();
			phone.title = other.Title;
			phone.company = other.Company;
			phone.Description = other.Description;
			phone.price = other.Price;
			return phone;
		}
    }
}
