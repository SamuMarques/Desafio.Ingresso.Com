using Desafio.Ingresso.Com.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sessao
    {
        public string IdSessao { get; set; }
        public string Hora { get; set; }
        public virtual IEnumerable<DiasDaSemana> DiasDaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual Filme Filme { get; set; }
    }
}
