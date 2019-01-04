using Desafio.Ingresso.Com.Domain.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sessao
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Hora { get; set; }
        public virtual IEnumerable<DiasDaSemana> DiasDaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string SalaId { get; set; }
        public string FilmeId { get; set; }
        public string CinemaId { get; set; }

        public bool CreateIsValid()
        {
            return DataInicio < DataFim 
                && !string.IsNullOrWhiteSpace(SalaId) 
                && !string.IsNullOrWhiteSpace(FilmeId) 
                && !string.IsNullOrWhiteSpace(CinemaId);
        }
    }
}
