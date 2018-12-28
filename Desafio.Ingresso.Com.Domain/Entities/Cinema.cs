using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Cinema
    {
        public string IdCinema { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }

        public virtual IEnumerable<Sala> Salas { get; set; }
    }
}
