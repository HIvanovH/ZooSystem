using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForTicketsType
    {
        private static readonly SearchForTicketsType _searchForTicketType = new SearchForTicketsType();

        public static SearchForTicketsType GetSearchForTicketsType()
        {
            return _searchForTicketType;
        }
        private SearchForTicketsType()
        {

        }
        public List<TicketsType> GetTicketsType()
        {
            var db = new ZooDbContext();
            return db.TicketsType.ToList();
        }
    }
}
