using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Create(T obj)
        {
            _repositoryBase.Create(obj);
        }

        public void Delete(string id)
        {
            _repositoryBase.Delete(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> filter)
        {
            return _repositoryBase.FindAllWhere(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public T GetById(string id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Update(string id, T obj)
        {
            _repositoryBase.Update(id, obj);
        }
    }
}
