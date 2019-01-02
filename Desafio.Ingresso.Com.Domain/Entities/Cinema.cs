﻿using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Cinema
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        public virtual IEnumerable<Sala> Salas { get; set; }
    }
}
