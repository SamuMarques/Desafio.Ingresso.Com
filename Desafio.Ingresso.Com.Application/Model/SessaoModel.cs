using Desafio.Ingresso.Com.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class SessaoModel
    {
        public string IdSessao { get; set; }
        public string Hora { get; set; }
        public virtual IEnumerable<DiasDaSemana> DiasDaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public virtual SalaModel Sala { get; set; }
        public virtual SessaoModel Filme { get; set; }
    }
}
