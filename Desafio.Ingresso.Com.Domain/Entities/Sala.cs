
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sala
    {
        public Guid Id { get; set; }
        public string Identificador { get; set; }
    }
}
