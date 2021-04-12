using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockConferenceAttendeesRepository : IConferenceManagerRepository<ConferenceAttendees>
    {
        public void Delete(ConferenceAttendees entity)
        {
            throw new NotImplementedException();
        }

        public ConferenceAttendees Get(int id)
        {
            throw new NotImplementedException();
        }

        public ConferenceAttendees Get(QueryOptions<ConferenceAttendees> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(ConferenceAttendees entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConferenceAttendees> List(QueryOptions<ConferenceAttendees> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ConferenceAttendees entity)
        {
            throw new NotImplementedException();
        }
    }
}
