using ConferenceManager.DataLayer;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ConferenceManager.Services.DataAccess.Repositories
{
    public class PresentationRepository<T> : ConferenceManagerUnitOfWork<T> where T : class
    {
        protected ConferenceManagerContext context { get; set; }
        private DbSet<T> dbSet { get; set; }
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
