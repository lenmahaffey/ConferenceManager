using System.Collections.Generic;

namespace ConferenceManager.Services.DataAccess.Interfaces
{
    interface IConferenceManagerRepository<T>
    {
        IEnumerable<T> List(QueryOptions<T> options);

        T Get(int id);
        T Get(QueryOptions<T> options = null);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();
    }
}
