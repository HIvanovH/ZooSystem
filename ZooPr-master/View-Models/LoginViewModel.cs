using Repository.Services;
using System.Windows;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Models;
using Zoo.Views;

namespace Zoo.View_Models
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private ICommand _command;

        public ICommand Command
        {
            get { return _command ?? (_command = new DelegateCommand(p => CheckLogin())); }
        }
        private void CheckLogin()
        {
            TicketsViewModel.UserId = CheckUserLogin.GetCheckUserLogin().ReturnUserId(Username,_password);
            if(TicketsViewModel.UserId != 0) {
                LoginSuccessfully();
            }
            else
            {
                ShowErrorLoginMessage();
            }
            
        }
        public void ShowErrorLoginMessage()
        {
            MessageBox.Show("Грешно потребителско име или парола!");
        }
        public void LoginSuccessfully()
        {
            var win = new MainWindow();
            win.Content = new MenuViewModel();
            win.Show();
            Application.Current.MainWindow.Close();
        }
        
        public string Username { 
            get { return _username; } 
            set { 
                _username = value;
                OnPropertyChanged(nameof(Username)); 
            } 
        }
        public string Password
        {
            get { return _password; }
            set { _password = value;
            OnPropertyChanged(nameof(Password));}
        }
       
    }
}
