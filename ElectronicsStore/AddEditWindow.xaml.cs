using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop_MVVM_db
{
	/// <summary>
	/// Логика взаимодействия для AddEditWindow.xaml
	/// </summary>
	public partial class AddEditWindow : Window
	{
		public Object Obj { get; private set; }
		public AddEditWindow()
		{
			InitializeComponent();
		}
		public AddEditWindow(Object obj)
		{
			InitializeComponent();
			this.Obj = obj;
			DataContext = Obj;
		}
		private void Button_OK(object sender, RoutedEventArgs e)
		{
			if (CheckPrice())
			{
				DialogResult = true;
				Close();
			}
		}

		private void Button_Cancel(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}
		private bool CheckPrice()
		{
			if (textBoxPrice.Text.All(x => char.IsDigit(x)))
				return true;
			else MessageBox.Show("Цена целое число!");
			return false;
		}
	}
}
