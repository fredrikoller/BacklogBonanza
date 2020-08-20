using System.Collections.Generic;

namespace BacklogBonanza.Core.Services
{
    public interface IService<T>
    {
        IEnumerable<T> Get();
        T Get(string id);
        T Create(T obj);
        T Update(string id, T obj);
        void Delete(string id);
    }
}