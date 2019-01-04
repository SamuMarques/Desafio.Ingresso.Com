using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Desafio.Ingresso.Com.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Create(T obj);
        IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Update(string id, T obj);
        void Delete(string id);
        void Dispose();
        bool Any(Expression<Func<T, bool>> filter);
    }
}
