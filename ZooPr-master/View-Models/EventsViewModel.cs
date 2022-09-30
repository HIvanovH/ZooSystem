using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Zoo.Models;

namespace Zoo.View_Models
{
    public class EventsViewModel : ViewModelBase
    {
        private List<EventsType> _eventTypes;
        private EventsType _sEventsType;
        private List<EventToDisplay> _events;
        private DateTime? _sDate = null;
        private ICommand _searchEvents;
        private EventToDisplay _sEvent;

        public ICommand SearchEvents
        {
            get
            {
                return _searchEvents ?? (_searchEvents = new DelegateCommand(context =>
                {
                    SearchAction();
                }));
            }
        }


        public void SearchAction()
        {
            //checks if date is null or not and checks if the type for event chosen by the user is null or not
            //then selects the events by the condition
           
        }

        public void DisplayEventType()
        {
            //Displays all types of events in a combobox
 
        }

        public EventsType SEventsType
        {
            get { return _sEventsType; }
            set
            {
                _sEventsType = value;
                OnPropertyChanged("SEventsType");

            }
        }
        public DateTime? SDate
        {
            get { return _sDate; }
            set
            {
                _sDate = value;
                OnPropertyChanged("SDate");
            }
        }
        public List<EventToDisplay> Events
        {
            get { return _events; }
            set
            {
                _events = value;
                OnPropertyChanged("Events");
            }
        }
        public EventToDisplay SEvent
        {
            get
            {
                return _sEvent;
            }
            set
            {
                _sEvent = value;
                OnPropertyChanged("SEvent");
            }
        }
        public List<EventsType> EventTypes
        {
            get { return _eventTypes; }
            set
            {
                _eventTypes = value;
                OnPropertyChanged("EventTypes");
            }
        }
        public EventsViewModel()
        {
            DisplayEventType();
        }
    }
}
