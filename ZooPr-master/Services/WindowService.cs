using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Zoo.View_Models;

namespace Zoo.Services
{
    //public delegate void LoginWindowService();
    internal class WindowService 
    {
       
        public void ShowMenuWindow()
        {
            var win = new Window();
            win.Content = new MenuViewModel();
            win.Show();

        }
        public void CloseLoginView()
        {
            Application.Current.MainWindow.Close();
        }
        
    }
}
