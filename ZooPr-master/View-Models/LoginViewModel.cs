using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private readonly MainViewModel _mainViewModel;
        private List<User> _users;
        public User currentUser;
        public List<User> Users { get; set; }


        private ICommand _command;
        public ICommand Command
        {
            get { return _command ?? (_command = new DelegateCommand(p => LoginSuccessfully())); }
        }
        public void LoginSuccessfully()
        {
            var win = new Window();
            win.Content = new MenuViewModel();
            win.Show();
            Application.Current.MainWindow.Close();
        }
        public string Username { get { return _username; } set { _username = value; OnPropertyChanged("Username"); } }


    }
}
