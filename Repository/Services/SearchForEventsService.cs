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
        private ZooDbContext zooDbContext;
        public static SearchForEventsService GetSearchForAnimalService()
        {
            return _searchForEventsService;
        }
        private SearchForEventsService()
        {
            zooDbContext = new ZooDbContext();
        }
        public List<Event> SearchForEvents(DateTime? date, EventsType? eventsType)
        {
            //checks if date is null or not and checks if the type for event chosen by the user is null or not
            //then selects the events by the condition
            if (date != null && eventsType == null)
            {
                return zooDbContext
                    .Event
                    .Where(e => e.Date == date)
                    .Select(e => e)
                    .ToList();

            }
            else if (date == null && eventsType != null)
            {
                return zooDbContext
                    .Event
                    .Where(e => e.IdType == eventsType.IdType)
                    .ToList();

            }
            else if (date != null && eventsType != null)
            {
                return zooDbContext
                    .Event
                    .Where(e => e.IdType == eventsType.IdType && e.Date == date)
                    .ToList();

            }
            else
            {
                return zooDbContext
                    .Event
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
