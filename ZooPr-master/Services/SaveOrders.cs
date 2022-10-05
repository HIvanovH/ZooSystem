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
    public class SaveOrders
    {
        private static readonly SaveOrders _saveOrders = new SaveOrders();
       
        public static SaveOrders GetSaveOrders()
        {
            return _saveOrders;
        }
        private SaveOrders()
        {
           
        }
        public void SaveChanges(List<Ticket> TicketsList)
        {
            var db = new ZooDbContext();
            if (TicketsList.Count != 0)
            {
                foreach (Ticket ticket in TicketsList)
                {
                    for (int i = 0; i < ticket.Number; i++)
                    {
                        UserOrdercs userOrders = new UserOrdercs(TicketsViewModel.UserId, ticket.IdType);
                        db.UserOrdercs.Add(userOrders);
                    }
                }
                db.SaveChanges();

            }
        }
        
        
    }
}
