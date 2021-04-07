using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceManager.Services.DataAccess
{
    public class ConferenceManagerRepository<T> : IConferenceManagerRepository<T> where T : class
    {
        protected ConferenceManagerContext context;
        private DbSet<T> data { get; set; }
        public ConferenceManagerRepository(ConferenceManagerContext ctx)
        {
            context = ctx;
            data = context.Set<T>();
        }
        public void Delete(T entity)
        {
            context.Remove(entity);
        }

        public T Get(int id)
        {
            return data.Find(id);
        }

        public T Get(QueryOptions<T> options)
        {
            IQueryable<T> query = BuildQuery(options);
            return query.FirstOrDefault();
        }

        public void Insert(T entity)
        {
            data.Add(entity);
        }

        public IEnumerable<T> List()
        {
            return data.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            data.Update(entity);
        }
        private IQueryable<T> BuildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = data;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
                foreach (var clause in options.WhereClauses)
                {
                    query = query.Where(clause);
                }
            if (options.HasOrderBy)
            {
                query = query.OrderBy(options.OrderBy);
            }
            return query;
        }

        public IEnumerable<T> List(QueryOptions<T> options)
        {
            throw new NotImplementedException();
        }
    }
}
