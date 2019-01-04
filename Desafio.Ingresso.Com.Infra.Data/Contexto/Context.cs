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
            database = new MongoClient("mongodb://admin:desenv1@ds147684.mlab.com:47684/samuelsdb").GetDatabase("samuelsdb");
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
                return database.GetCollection<Filme>("Filmes");
            }
        }

        public IMongoCollection<Cinema> Cinema
        {
            get
            {
                return database.GetCollection<Cinema>("Cinemas");
            }
        }

        public IMongoCollection<Sessao> Sessao
        {
            get
            {
                return database.GetCollection<Sessao>("Sessaos");
            }
        }

        public IMongoCollection<Cidade> Cidade
        {
            get
            {
                return database.GetCollection<Cidade>("Cidades");
            }
        }
    }
}
