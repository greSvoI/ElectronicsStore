using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_MVVM_db
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ViewShop shop = new ViewShop();
		public MainWindow()
		{
			InitializeComponent();
			listbox.SelectionChanged += Listbox_SelectionChanged;
			listbox2.SelectionChanged += Listbox2_SelectionChanged;
			listbox.Items.Add("Смартфоны >");
			listbox.Items.Add("Телевизоры >");
			listbox.Items.Add("Ноутбуки     >");
			
		}

		private void Listbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
		}

		private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			listbox2.ItemsSource = shop.Phones.Local.ToBindingList();
		}

		private void buttonAdd_Click(object sender, RoutedEventArgs e)
		{

		}

		private void buttonEdit_Click(object sender, RoutedEventArgs e)
		{

		}

		private void buttonDel_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
