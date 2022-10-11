using Repository.Services;
using Syncfusion.Windows.Shared;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Repository.Models;
using Zoo.Models;
namespace Zoo.View_Models
{
    public class TicketsViewModel : ViewModelBase
    {
        #region Private Fields
        private List<TicketsType> _ticketsTypes;
        private ObservableCollection<Ticket> _ticketsList;
        private TicketsType? _selectetType;
        private Ticket _ticket;
        private double _selectedValue;
        private double _finalPrice;
        private ICommand _saveTicketsToDb;
        private ICommand _displayTicketsOnTable;
        private int _sValue;
        public int SValue { get { return _sValue; }
            set { _sValue = value;
                OnPropertyChanged(nameof(SValue));
            } }
        #endregion
        public static User User { get; set; }

        public ICommand DisplayTicketsOnTable
        {
            get
            {
                return _displayTicketsOnTable ?? (_displayTicketsOnTable = new DelegateCommand(context => CalculateDetailsForOrder()));
            }
        }
        public ICommand SaveTicketsToDb
        {
            get
            {
                return _saveTicketsToDb ?? (_saveTicketsToDb = new DelegateCommand(context => SaveAction()));
            }
        }
        public void SaveAction()
        {
           
            List<Ticket> ticketsToSave = new List<Ticket>();
            ticketsToSave.AddRange(TicketsList);
            WrapOrders.GetSaveOrders().SaveChanges(ticketsToSave);
            TicketsList.Clear();
            FinalPrice = 0;
            SelectedValue = 0;
            SelectedType = null;

        }
        public void CalculateDetailsForOrder()
        {
            if (SelectedType != null)
            {
                if ((int)SelectedValue != 0)
                {
                    Ticket = new Ticket();
                    Ticket.Type = SelectedType.Type;
                    Ticket.IdType = SelectedType.TypeTicketId;
                    Ticket.Price = SelectedType.price;
                    Ticket.Number = (int)SelectedValue;
                    TicketsList.Add(Ticket);
                    FinalPrice += SelectedType.price * SelectedValue;
                }
                else { MessageBox.Show("Броят на билетите не може да бъде по-малък от 1"); }

            }
            else
            {
                MessageBox.Show("Моля изберете тип на билета");
            }


        }
        public void DisplayTicketsType()
        {
            //displays all types of tickets in a combobox
            TicketsTypes = SearchForTicketsType.GetSearchForTicketsType().GetTicketsType();
        }

        public List<TicketsType> TicketsTypes
        {
            get { return _ticketsTypes; }
            set
            {
                _ticketsTypes = value;
                OnPropertyChanged(nameof(TicketsTypes));
            }
        }
        public ObservableCollection<Ticket> TicketsList
        {
            get { return _ticketsList; }
            set
            {
                _ticketsList = value;
                OnPropertyChanged(nameof(TicketsList));
            }
        }
        public double FinalPrice
        {
            get { return _finalPrice; }
            set
            {
                _finalPrice = value;
                OnPropertyChanged(nameof(FinalPrice));
            }
        }
        public Ticket Ticket
        {
            get { return _ticket; }
            set
            {
                _ticket = value;
                OnPropertyChanged(nameof(Ticket));
            }
        }
        public TicketsType? SelectedType
        {
            get { return _selectetType; }
            set
            {
                _selectetType = value;
                OnPropertyChanged(nameof(SelectedType));

            }
        }
        public double SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                _selectedValue = value;
                OnPropertyChanged(nameof(SelectedValue));

            }
        }
        public TicketsViewModel()
        {
            DisplayTicketsType();
            _ticketsList = new ObservableCollection<Ticket>();
            FinalPrice = 0;
        }
    }
}
