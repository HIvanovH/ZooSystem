using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Data;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class LoginViewModel : ViewModelBase
    {
        public ZooDbContext dBContext = new ZooDbContext();
        private string _username;
        private string _password;
        private readonly MainViewModel _mainViewModel;
        private List<User> _users;
        public User currentUser;
        public List<User> Users { get; set; }


        private ICommand _command;
        public ICommand Command
        {
            get { return _command ?? (_command = new LoginCommand()); }
        }

        public string Username { get { return _username; } set { _username = value; OnPropertyChanged("Username"); } }
       

    }
}
