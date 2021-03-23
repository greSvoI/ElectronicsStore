using ElectronicsStore.Command;
using ElectronicsStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ElectronicsStore.View
{
    public class ViewWindowAddEdit : INotifyPropertyChanged
    {
        public VariousElectronics OtherElectronics = new VariousElectronics();
        public string Title { get => OtherElectronics.Title; set { OtherElectronics.Title = value;OnPropertyChanged(""); } }
        public double Price { get => OtherElectronics.Price; set { OtherElectronics.Price = value; OnPropertyChanged(""); } }
        public string Company { get => OtherElectronics.Company; set { OtherElectronics.Company = value; OnPropertyChanged(""); } }
        public string Description { get => OtherElectronics.Description; set { OtherElectronics.Description = value; OnPropertyChanged(""); } }
        public WindowAddEdit WindowAddEdit { get; }
        public ViewWindowAddEdit(WindowAddEdit windowAddEdit)
        {
            WindowAddEdit = windowAddEdit;
        }

        public ICommand ClickOk => new DelegateCommand(()=> 
        {
            if (CheckPrice() && !string.IsNullOrEmpty(WindowAddEdit.textTitle.Text) && !string.IsNullOrEmpty(WindowAddEdit.textCompany.Text))
            {
                WindowAddEdit.DialogResult = true;
                WindowAddEdit.Close();
            }

        });
        public ICommand ClickCancel => new DelegateCommand(() => 
        {
            WindowAddEdit.DialogResult = false;
            WindowAddEdit.Close();
            
        });

       

        private bool CheckPrice()
        {
            if (Price.ToString().All(x => char.IsDigit(x)))
                return true;
            else MessageBox.Show("Цена целое число!");
            return false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
