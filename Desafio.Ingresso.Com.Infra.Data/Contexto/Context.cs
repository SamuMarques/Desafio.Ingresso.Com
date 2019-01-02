using MongoDB.Driver;
using Desafio.Ingresso.Com.Domain.Entities;
using System.Linq;
using System.Reflection;
using MongoDbGenericRepository.Attributes;
using MongoDbGenericRepository.Utils;

namespace Desafio.Ingresso.Com.Infra.Data.Contexto
{
    public class Context 
    {
        private readonly IMongoDatabase database;

        public Context()
        {
            database = new MongoClient("mongodb://admin:desenv1@ds113873.mlab.com:13873/samuelsdb").GetDatabase("samuelsdb");
        }
        #region Generic

        public IMongoCollection<TDocument> GetCollection<TDocument>() where TDocument : class
        {
            return database.GetCollection<TDocument>(GetCollectionName<TDocument>());
        }

        private string GetCollectionName<TDocument>()
        {
            return GetAttributeCollectionName<TDocument>() ?? Pluralize<TDocument>();
        }

        private string Pluralize<TDocument>()
        {
            return (typeof(TDocument).Name.Pluralize()).Camelize();
        }

        private string GetAttributeCollectionName<TDocument>()
        {
            return (typeof(TDocument).GetTypeInfo()
                                     .GetCustomAttributes(typeof(CollectionNameAttribute))
                                     .FirstOrDefault() as CollectionNameAttribute)?.Name;
        }
        
        #endregion

        public IMongoCollection<Filme> Filme
        {
            get
            {
                return database.GetCollection<Filme>("Filme");
            }
        }

        public IMongoCollection<Cinema> Cinema
        {
            get
            {
                return database.GetCollection<Cinema>("Cinema");
            }
        }

        public IMongoCollection<Sessao> Sessao
        {
            get
            {
                return database.GetCollection<Sessao>("Sessao");
            }
        }
    }
}
