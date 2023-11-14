using P.NET_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_NET.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {


        public RelayCommand  HomeViewCommand { get; set; }
        public RelayCommand ServersViewCommand { get; set; }
        public RelayCommand AccountViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand RegistrationViewCommand { get; set; }
        public RelayCommand LoginViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }
        public ServersViewModel ServersVm { get; set; }
        public AccountViewModel AccountVm { get; set; }
        public SettingsViewModel SettingsVm { get; set; }
        public RegistrationViewModel RegistrationVm { get; set; }
        public LoginViewModel LoginVm { get; set; }

        private object _currentView;
        public object CurrentView 
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnProperyChanged();
            } 
        }
        public MainViewModel() 
        {
            HomeVm = new HomeViewModel();
            ServersVm = new ServersViewModel();
            AccountVm = new AccountViewModel();
            SettingsVm = new SettingsViewModel();
            RegistrationVm = new RegistrationViewModel();
            LoginVm = new LoginViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVm;
            
            });

            ServersViewCommand = new RelayCommand(o =>
            {
                CurrentView = ServersVm;

            });

            AccountViewCommand = new RelayCommand(o =>
            {
                CurrentView = AccountVm;

            });
            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVm;

            });
            RegistrationViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegistrationVm;

            });
            LoginViewCommand = new RelayCommand(o =>
            {
                CurrentView = LoginVm;

            });
        }
    }
}
