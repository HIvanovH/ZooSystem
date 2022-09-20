using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class MenuViewModel : ViewModelBase
    {
        private ViewModelBase _optionViewModel;
        public ViewModelBase OptionViewModel 
        { 
            get 
            { return _optionViewModel; }
            set{
                _optionViewModel = value;
                OnPropertyChanged("OptionViewModel"); 
            } 
        }

        private ICommand _chooseOptioncommand;
        public ICommand MenuCommand
        {
            get { return _chooseOptioncommand ?? (_chooseOptioncommand = new MenuCommand(this)); }
        }

    }
}
