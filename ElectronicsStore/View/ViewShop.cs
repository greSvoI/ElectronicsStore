using ElectronicsStore.Command;
using ElectronicsStore.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ElectronicsStore
{
    public class ViewShop : INotifyPropertyChanged
    {
        private BaseShop Shop = new BaseShop();
        public BaseShop BaseShop { get => Shop; set { Shop = value; OnPropertyChanged(""); } }
        public ICommand SaveItemShop => new DelegateCommand(() =>{ BaseShop.SaveChanges(); });
        public ICommand DelItemShop => new DelegateCommand(()=> { BaseShop.DelItem(); });
        public ICommand AddItemShop => new DelegateCommand(()=> { BaseShop.AddItem(); });
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
