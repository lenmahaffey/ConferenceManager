using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockEventAttendeesRepository : IConferenceManagerRepository<EventAttendees>
    {
        public void Delete(EventAttendees entity)
        {
            throw new NotImplementedException();
        }

        public EventAttendees Get(int id)
        {
            throw new NotImplementedException();
        }

        public EventAttendees Get(QueryOptions<EventAttendees> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(EventAttendees entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventAttendees> List(QueryOptions<EventAttendees> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(EventAttendees entity)
        {
            throw new NotImplementedException();
        }
    }
}
