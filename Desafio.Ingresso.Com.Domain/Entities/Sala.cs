
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sala
    {
        public Sala()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Identificador { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
