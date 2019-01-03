using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class CinemaModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        public virtual IEnumerable<SalaModel> Salas { get; set; }
    }
}
