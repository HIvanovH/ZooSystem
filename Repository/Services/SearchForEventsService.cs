using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForEventsService 
    {
        private static readonly SearchForEventsService _searchForEventsService = new SearchForEventsService();
        public static SearchForEventsService GetSearchForAnimalService()
        {
            return _searchForEventsService;
        }
        private SearchForEventsService()
        {

        }
        public List<Event> SearchForEvents(DateTime? date, EventsType? eventsType)
        {
            //checks if date is null or not and checks if the type for event chosen by the user is null or not
            //then selects the events by the condition
            
            using(var db = new ZooDbContext())
            {
                return db.Event.Where(e => (eventsType != null) ? e.Date == date && e.EventsType.IdType == eventsType.IdType : true)
             .ToList();
            }
           

            
        }

        public List<EventsType> DisplayEventType()
        {
            //rerutns all event types
            var db = new ZooDbContext();
            return db.EventsType.ToList();
        }
    }
}
