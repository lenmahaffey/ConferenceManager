using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace ConferenceManager.Services.DataAccess.Repositories
{
    public class VenueRepository<T> : ConferenceManagerUnitOfWork<T> where T : class
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(QueryOptions<T> options)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(QueryOptions<T> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
