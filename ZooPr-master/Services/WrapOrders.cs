using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;
using Zoo.View_Models;

namespace Repository.Services
{
    public class WrapOrders
    {
        private static readonly WrapOrders _saveOrders = new WrapOrders();
       
        public static WrapOrders GetSaveOrders()
        {
            return _saveOrders;
        }
        private WrapOrders()
        {
           
        }
        public void SaveChanges(List<Ticket> TicketsList)
        {
            List<UserOrders> ordersToSave = new List<UserOrders>();
            if (TicketsList.Count != 0)
            {
                foreach (Ticket ticket in TicketsList)
                {
                    for (int i = 0; i < ticket.Number; i++)
                    {
                        UserOrders userOrders = new UserOrders(TicketsViewModel.UserId, ticket.IdType);
                        ordersToSave.Add(userOrders);
                        SaveOrders.GetSaveOrders().SaveChanges(ordersToSave);
                    }
                }
  

            }
        }
        
        
    }
}
