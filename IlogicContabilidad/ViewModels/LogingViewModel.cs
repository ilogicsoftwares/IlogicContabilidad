using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IlogicContabilidad.Windows;
using System.Windows.Controls;
using System.Windows;

namespace IlogicContabilidad.ViewModels
{
    class LogingViewModel:ViewModelBase
    {

        public RelayCommand LogingCommand { get; set; }

        public LogingViewModel()
        {
            LogingCommand = new RelayCommand(Login);
            Users = bd.users.ToList();
        }

        private void Login(object obj)
        { 
            var password = obj as PasswordBox;
           Window windowsender = Window.GetWindow(password);
            if (password.Password.Equals(this._Selecteduser.keyCi.Trim()))
            {
                PrincipalWindow Mainwindow = new PrincipalWindow();
                Mainwindow.WindowState = System.Windows.WindowState.Maximized;
                Mainwindow.Show();
               
                windowsender.Close();
                
            }else
            {
                this.Validator = "Clave Incorrecta";
                password.Focus();
                password.Password = string.Empty;
            }
        }

        private List<users> _Users;
        public List<users> Users
        {
            get { return _Users; }
            set { _Users = value;
                NotifyPropertyChanged();
            }
        }

        private users _Selecteduser;
        public users Selecteduser
        {
            get { return _Selecteduser; }
            set
            {
                _Selecteduser = value;
                NotifyPropertyChanged();
            }
        }
        

    }
}
