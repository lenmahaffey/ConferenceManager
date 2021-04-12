using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockVenuesRepository : IConferenceManagerRepository<Venue>
    {
        public void Delete(Venue entity)
        {
            throw new NotImplementedException();
        }

        public Venue Get(int id)
        {
            throw new NotImplementedException();
        }

        public Venue Get(QueryOptions<Venue> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venue entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venue> List(QueryOptions<Venue> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Venue entity)
        {
            throw new NotImplementedException();
        }
    }
}
