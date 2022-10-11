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
        public List<Event> SearchForEvents(DateTime? date, EventsType eventsType)
        {
            //checks if date is null or not and checks if the type for event chosen by the user is null or not
            //then selects the events by the condition
           // return zooDbContext.Event.Where(e => date != null ? e.Date == date && e.TypeId == eventsType.TypeId : e.TypeId == eventsType.TypeId).FirstOrDefault();
           
            if (eventsType.TypeId == 1)
            {
                if (date != null)
                { 
                    return zooDbContext
                    .Event
                    .Where(e => e.Date == date &&  e.IsDeleted == false)
                    .ToList();
                }
                return zooDbContext
                    .Event.Where(e=>e.IsDeleted == false)
                    .ToList();
            }
            else
            {
                if (date != null)
                {
                    return zooDbContext
                    .Event
                    .Where(e => e.Date == date && e.TypeId==eventsType.TypeId && e.IsDeleted == false)
                    .ToList();
                }
                return zooDbContext
                   .Event
                   .Where(e => e.TypeId == eventsType.TypeId && e.IsDeleted == false)
                   .ToList();
            }
            
        }
       
       /* public List<EventsType> DisplayEventType()
        {
            //rerutns all event types
            var db = new ZooDbContext();
            return db.EventsType.ToList();
        }*/
    }
}
