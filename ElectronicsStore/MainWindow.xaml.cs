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

namespace ElectronicsStore
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public  ViewShop shop = new ViewShop();
		public MainWindow()
		{
			InitializeComponent();
			DataContext = shop;

			listbox.SelectionChanged += Listbox_SelectionChanged;

		}

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox.SelectedIndex == 0)
                listboxItems.ItemsSource = shop.BaseShop.Phones.Local.ToBindingList();
            else if (listbox.SelectedIndex == 1)
                listboxItems.ItemsSource = shop.BaseShop.TVs.Local.ToBindingList();
            else if (listbox.SelectedIndex == 2)
                listboxItems.ItemsSource = shop.BaseShop.Laptops.Local.ToBindingList();
        }
    }
}
