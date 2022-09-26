using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Data;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        public ZooDbContext dBContext = new ZooDbContext();
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

    }
}
