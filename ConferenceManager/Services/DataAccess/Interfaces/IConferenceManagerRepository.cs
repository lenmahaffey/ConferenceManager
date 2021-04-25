using System.Collections.Generic;

namespace ConferenceManager.Services.DataAccess.Interfaces
{
    public interface IConferenceManagerRepository<T>
    {
        IEnumerable<T> List(QueryOptions<T> options);
        IEnumerable<T> List();

        T Get(int id);
        T Get(QueryOptions<T> options);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();
    }
}
