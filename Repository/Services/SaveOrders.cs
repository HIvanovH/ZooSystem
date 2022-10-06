using Repository.Data;
using Repository.Models;
using System.Collections.Generic;


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
        public void SaveChanges(List<UserOrders> userOrders)
        {
            var db = new ZooDbContext();
            db.UserOrders.AddRange(userOrders);
            db.SaveChanges();

        }
        
        
    }
}
