using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Infra.Data.Contexto;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Desafio.Ingresso.Com.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected Context Db = new Context();
        public void Create(T obj)
        {
            Db.GetCollection<T>().InsertOne(obj);
        }

        public IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> filter)
        {
            return Db.GetCollection<T>().Find(filter).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.GetCollection<T>().Find(x => true).ToList();
        }

        public T GetById(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return Db.GetCollection<T>().Find(filter).FirstOrDefault();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Update(string id, T obj)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            Db.GetCollection<T>().ReplaceOne(filter, obj);
        }

        public void Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            Db.GetCollection<T>().DeleteOne(filter);
        }
    }
}
