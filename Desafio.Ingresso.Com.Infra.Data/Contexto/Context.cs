using Desafio.Ingresso.Com.Domain.Entities;
using MongoDB.Driver;

namespace Desafio.Ingresso.Com.Infra.Data.Contexto
{
    public class Context
    {
        private readonly IMongoDatabase database;

        public Context()
        {
            database = new MongoClient("mongodb://admin:desenv1@ds113873.mlab.com:13873/samuelsdb").GetDatabase("samuelsdb");
        }

        public IMongoCollection<Filme> Filmes
        {
            get
            {
                return database.GetCollection<Filme>("Filmes");
            }
        }

        public IMongoCollection<Cinema> Cinemas
        {
            get
            {
                return database.GetCollection<Cinema>("Cinemas");
            }
        }

        public IMongoCollection<Sessao> Sessoes
        {
            get
            {
                return database.GetCollection<Sessao>("Sessoes");
            }
        }
    }
}
