using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore.Model
{
	public interface IShop
	{
		
		int id { get; set; }
		string Title { get; set; }
		double Price { get; set; }
		string Company { get; set; }
		string Description { get; set; }
		IShop ShopToItem(VariousElectronics other);
	}
}
