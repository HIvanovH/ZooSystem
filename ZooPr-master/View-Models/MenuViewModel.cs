using System.Windows.Input;
using Zoo.Commands;

namespace Zoo.View_Models
{
    public class MenuViewModel : ViewModelBase
    {
        private ViewModelBase _optionViewModel;
        private ICommand _openAnimalsCommand;
        private ICommand _openEventsCommand;

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
        public MenuViewModel()
        {
          
            OptionViewModel = new AnimalViewModel();
            
        }
    }
}
