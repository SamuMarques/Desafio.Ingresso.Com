using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Filme
    {
        public string IdFilme { get; set; }
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public int Duracao { get; set; }
    }
}
