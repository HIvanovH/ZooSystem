using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Zoo.View_Models;
using Zoo.Views;
using Zoo.Views.Loading_Screen;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var loadingWindow = new LoadingWindow();
            this.MainWindow = loadingWindow;
            loadingWindow.Show();
            LoginView loginWindow;
            Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(15);
                    loadingWindow.Dispatcher.Invoke(() => loadingWindow.Progress = i);
                }
                this.Dispatcher.Invoke(() =>
                {
                    loginWindow = new LoginView();
                    this.MainWindow = loginWindow;
                    loginWindow.Show();
                    loadingWindow.Close();
                });
            });
            
        }
        

    }
}
