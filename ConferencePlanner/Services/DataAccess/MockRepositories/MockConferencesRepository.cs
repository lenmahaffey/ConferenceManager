using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockConferencesRepository : IConferenceManagerRepository<Conference>
    {
        private List<Conference> conferences;

        public MockConferencesRepository()
        {
            if (conferences == null)
            {
                initalizeConferences();
            }
        }
        private void initalizeConferences()
        {
            conferences = new List<Conference>()
            {
                new Conference
                {
                    ID = 1001,
                    Name = "International Association of National Associations",
                    Description = "The largest gathering of national association directors and managers in the world.",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(4)
                },
                new Conference
                {
                    ID = 1002,
                    Name = "Acme Corp",
                    Description = "An exposition of the latest in roadrunner hunting equipment",
                    StartDate = DateTime.Today.AddDays(5),
                    EndDate = DateTime.Today.AddDays(9)
                }
            };
        }
        public void Delete(Conference entity)
        {
            conferences.Remove(entity);
        }

        public Conference Get(int id)
        {
            return conferences.FirstOrDefault(c => c.ID == id);
        }

        public Conference Get(QueryOptions<Conference> options)
        {
            IQueryable<Conference> query = (IQueryable<Conference>)conferences;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
            {
                foreach (var clause in options.WhereClauses)
                {
                    query = query.Where(clause);
                }
            }
            if (options.HasOrderBy)
            {
                query = query.OrderBy(options.OrderBy);
            }
            return query.FirstOrDefault();
        }

        public void Insert(Conference entity)
        {
            conferences.Add(entity);
        }

        public IEnumerable<Conference> List(QueryOptions<Conference> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Conference entity)
        {
            conferences[conferences.FindIndex(i => i.ID == entity.ID)] = entity;
        }
    }
}
