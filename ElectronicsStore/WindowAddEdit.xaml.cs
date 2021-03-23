﻿using ElectronicsStore.View;
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

namespace ElectronicsStore
{
	/// <summary>
	/// Логика взаимодействия для WindowAddEdit.xaml
	/// </summary>
	public partial class WindowAddEdit : Window
	{
		public ViewWindowAddEdit view;
		public WindowAddEdit()
		{
			InitializeComponent();
			DataContext = view = new ViewWindowAddEdit(this);
		}
	}
}
