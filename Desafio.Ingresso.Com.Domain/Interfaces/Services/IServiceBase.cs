using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T obj);
        IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Update(string id, T obj);
        void Delete(string id);
        void Dispose();
    }
}
