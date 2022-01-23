using EntityFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models.ViewModels
{
    internal class MainWindowViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public RelayCommand CustomerViewCommand { get; set; }
        public RelayCommand AddCustomerViewCommand { get; set;}
        public RelayCommand AddErrandViewCommand { get; set; }
        public RelayCommand ErrandViewCommand { get; set; }

        public CustomerViewModel CustomerViewModel { get; set; }
        public AddCustomerViewModel AddCustomerViewModel { get; set; }  
        public AddErrandViewModel AddErrandViewModel { get; set; }
        public ErrandViewModel ErrandViewModel { get; set; }

        public MainWindowViewModel()
        {
            CustomerViewModel = new CustomerViewModel();
            AddCustomerViewModel = new AddCustomerViewModel();
            AddErrandViewModel = new AddErrandViewModel();
            ErrandViewModel = new ErrandViewModel();

            CurrentView = ErrandViewModel;

            CustomerViewCommand = new RelayCommand(x => CurrentView = CustomerViewModel);
            AddCustomerViewCommand = new RelayCommand(x => CurrentView = AddCustomerViewModel);
            AddErrandViewCommand = new RelayCommand(x => CurrentView = AddErrandViewModel);
            ErrandViewCommand = new RelayCommand(x => CurrentView = ErrandViewModel);

        }
    }
}
