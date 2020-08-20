using System.Collections.Generic;

namespace BacklogBonanza.Core.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Get(string id);
        T Create(T obj);
        T Update(string id, T obj);
        void Delete(string id);
    }
}