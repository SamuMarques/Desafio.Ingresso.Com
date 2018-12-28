using Desafio.Ingresso.Com.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Infra.Data.Contexto
{
    public class Context
    {
        private readonly IMongoDatabase database;

        public Context()
        {
            database = new MongoClient("mongodb://admin:desenv1@ds113873.mlab.com:13873/samuelsdb").GetDatabase("samuelsdb");
        }

        public IMongoCollection<Filme> Posts
        {
            get
            {
                return database.GetCollection<Filme>("Filmes");
            }
        }
    }
}
