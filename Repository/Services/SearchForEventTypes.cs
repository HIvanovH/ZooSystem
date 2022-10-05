using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForEventTypes
    {
        private static readonly SearchForEventTypes _searchForEventTypes = new SearchForEventTypes();

        public static SearchForEventTypes GetSearchForEventTypes()
        {
            return _searchForEventTypes;
        }
        private SearchForEventTypes()
        {

        }
        public List<EventsType> GetEventTypes()
        {
            var db = new ZooDbContext();
            return db.EventsType.ToList();
        }

    }
}
