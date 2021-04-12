using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockRoomsRepository : IConferenceManagerRepository<Room>
    {
        public void Delete(Room entity)
        {
            throw new NotImplementedException();
        }

        public Room Get(int id)
        {
            throw new NotImplementedException();
        }

        public Room Get(QueryOptions<Room> options = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Room entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> List(QueryOptions<Room> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}
