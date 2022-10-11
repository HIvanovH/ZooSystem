using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Repository.Models;
using Repository.Services;
using System.Windows.Controls;
using System.Windows;

namespace Zoo.View_Models
{
    public class EventsViewModel : ViewModelBase
    {
        private List<EventsType> _eventTypes;
        private EventsType _selectedEventType;
        private List<Event> _events;
        private DateTime? _selectedDate = null;
        private ICommand _searchEvents;
        private Event _selectedEvent;
        private ICommand _deleteEvent;
        public ICommand DeleteEvent
        {
            get
            {
                return _deleteEvent ?? (_deleteEvent = new DelegateCommand(context =>
                {
                    DeleteEventAction();
                },p=>CanExecute()));
            }

        }
        public void DeleteEventAction()
        {
            if (SelectedEvent != null)
            {
                DeleteEventService.GetDeleteEventService().DeleteEvent(SelectedEvent);
                SearchAction();
            }
            else
            {
                MessageBox.Show("Не сте избрали събитие!");
            }
            
        }
        public bool CanExecute()
        {
            return TicketsViewModel.User.Role == Roles.Admin;
        }
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
            Events = SearchForEventsService.GetSearchForAnimalService().SearchForEvents(SelectedDate,SelectedEventsType);
        }
        public void DisplayEventType()
        {
            //Displays all types of events in a combobox
            EventTypes = SearchForEventTypes.GetSearchForEventTypes().GetEventTypes();
        }
        public EventsType SelectedEventsType
        {
            get { return _selectedEventType; }
            set
            {
                _selectedEventType = value;
                OnPropertyChanged(nameof(SelectedEventsType));
            }
        }
        public DateTime? SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }
        public List<Event> Events
        {
            get { return _events; }
            set
            {
                _events = value;
                OnPropertyChanged(nameof(Events));
            }
        }
        public Event SelectedEvent
        {
            get
            {
                return _selectedEvent;
            }
            set
            {
                _selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
            }
        }
        public List<EventsType> EventTypes
        {
            get { return _eventTypes; }
            set
            {
                _eventTypes = value;
                OnPropertyChanged(nameof(EventTypes));
            }
        }
        public EventsViewModel()
        {
            DisplayEventType();
            SelectedEventsType = EventTypes[0];
        }
    }
}
