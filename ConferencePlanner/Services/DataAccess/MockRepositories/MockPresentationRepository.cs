using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockPresentationRepository : IConferenceManagerRepository<Presentation>
    {
        public void Delete(Presentation entity)
        {
            throw new NotImplementedException();
        }

        public Presentation Get(int id)
        {
            throw new NotImplementedException();
        }

        public Presentation Get(QueryOptions<Presentation> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Presentation entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation> List(QueryOptions<Presentation> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Presentation entity)
        {
            throw new NotImplementedException();
        }
    }
}
