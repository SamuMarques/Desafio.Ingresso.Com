using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Update(T obj);
        void Delete(T obj);
    }
}
