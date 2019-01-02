using MongoDB.Bson.Serialization.Attributes;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Filme
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public int Duracao { get; set; }
    }
}
