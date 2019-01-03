using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Cinema
    {
        public Cinema()
        {
            Salas = new List<Sala>();
        }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        public virtual IList<Sala> Salas { get; set; }
    }
}
