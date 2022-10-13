using Repository.Services;
using System.CodeDom;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
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
        private MainWindow win;

        public LoginViewModel()
        {
            LoadMenuInBackround();
        }

        public ICommand Command
        {
            get { return _command ?? (_command = new DelegateCommand(p => CheckLogin())); }
        }
        private void CheckLogin()
        {
            TicketsViewModel.User = CheckUserLogin.GetCheckUserLogin().ReturnUserId(Username,_password);
            if(TicketsViewModel.User != null) {
                LoginSuccessfully();
            }
            else
            {
                ShowErrorLoginMessage();
            }
            
        }
        public void LoadMenuInBackround()
        {
            /*Task.Factory.StartNew(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {*/
                    win = new MainWindow();
                    win.Content = new MenuViewModel();
  /*      });
               });*/
            
        }
        public void ShowErrorLoginMessage()
        {
            MessageBox.Show("Грешно потребителско име или парола!");
        }
        public void LoginSuccessfully()
        {

            win.Show();
            Application.Current.MainWindow.Hide();
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
