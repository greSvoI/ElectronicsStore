using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_MVVM_db.Model
{
	interface IShop
	{
		
		int id { get; set; }
		string Title { get; set; }
		double Price { get; set; }
		string Company { get; set; }
		string Description { get; set; }

	}
}
