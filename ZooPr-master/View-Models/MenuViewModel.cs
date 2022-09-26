using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Models;
using DelegateCommand = Zoo.Commands.DelegateCommand;

namespace Zoo.View_Models
{
    public class MenuViewModel : ViewModelBase
    {
        private ViewModelBase _optionViewModel;
        private ICommand _openAnimalsCommand;
        private ICommand _openEventsCommand;
        public ViewModelBase OptionViewModel
        {
            get
            { return _optionViewModel; }
            set
            {
                _optionViewModel = value;
                OnPropertyChanged("OptionViewModel");
            }
        }


        public ICommand OpenAnimalsCommand
        {
            get { return _openAnimalsCommand ?? (_openAnimalsCommand = new DelegateCommand(p => OpenAnimalsView())); }
        }
        private ICommand _openTicketsCommand;
        public ICommand OpenTicketsCommand
        {
            get { return _openTicketsCommand ?? (_openTicketsCommand = new DelegateCommand(p => OpenTicketsView())); }
        }
        public ICommand OpenEventsCommand
        {
            get { return _openEventsCommand ?? (_openEventsCommand = new DelegateCommand(p => OpenEventsView())); }
        }

        private void OpenAnimalsView()
        {
            OptionViewModel = new AnimalViewModel();
        }
        private void OpenTicketsView()
        {
            OptionViewModel = new TicketsViewModel();
        }
        private void OpenEventsView()
        {
            OptionViewModel = new EventsViewModel();
        }

    }
}
