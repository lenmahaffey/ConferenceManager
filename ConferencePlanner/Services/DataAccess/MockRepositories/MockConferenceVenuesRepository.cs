using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockConferenceVenuesRepository : IConferenceManagerRepository<ConferenceVenues>
    {
        public void Delete(ConferenceVenues entity)
        {
            throw new NotImplementedException();
        }

        public ConferenceVenues Get(int id)
        {
            throw new NotImplementedException();
        }

        public ConferenceVenues Get(QueryOptions<ConferenceVenues> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(ConferenceVenues entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConferenceVenues> List(QueryOptions<ConferenceVenues> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ConferenceVenues entity)
        {
            throw new NotImplementedException();
        }
    }
}
