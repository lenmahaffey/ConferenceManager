using ConferenceManager.DataLayer;
using ConferenceManager.Models;
using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.Interfaces.MockRepos
{
    public class MockAttendeesRepository : IConferenceManagerRepository<Attendee>
    {
        public void Delete(Attendee entity)
        {
            throw new NotImplementedException();
        }

        public Attendee Get(int id)
        {
            throw new NotImplementedException();
        }

        public Attendee Get(QueryOptions<Attendee> options)
        {
            throw new NotImplementedException();
        }

        public void Insert(Attendee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Attendee> List(QueryOptions<Attendee> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Attendee entity)
        {
            throw new NotImplementedException();
        }
    }
}
