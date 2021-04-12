using ConferenceManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.Interfaces
{
    public class MockEventsRepository : IConferenceManagerRepository<Event>
    {
        public void Delete(Event entity)
        {
            throw new NotImplementedException();
        }

        public Event Get(int id)
        {
            throw new NotImplementedException();
        }

        public Event Get(QueryOptions<Event> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Event entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> List(QueryOptions<Event> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Event entity)
        {
            throw new NotImplementedException();
        }
    }
}
