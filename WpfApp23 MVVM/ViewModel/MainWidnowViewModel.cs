using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp23_MVVM.Model;
using WpfApp23_MVVM.MVVM;

namespace WpfApp23_MVVM.ViewModel
{
    internal class MainWidnowViewModel : ViewModelBase
    {
        public ObservableCollection<item> items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canExecute =>SelectedItem !=null);
        public RelayCommand SaveCommand => new RelayCommand(execute => CanSave());

        public MainWidnowViewModel() 
        {
            items = new ObservableCollection<item>();
        }
        private item selectedItem;

        public item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        private void AddItem()
        {
            items.Add(new item
            {
                Name ="New Item",
                SerialNumber="XXXXX",
                Quantity=0,
            });
        }
        private void DeleteItem()
        {
           items.Remove(selectedItem);
        }
        private void Save()
        {
           //save
        }
        private bool CanSave()
        {
            return true;
        }



    }

}
