using Desafio.Ingresso.Com.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class SessaoCrudModel
    {
        public string Id { get; set; }
        public string Hora { get; set; }
        public virtual IEnumerable<DiasDaSemana> DiasDaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string SalaId { get; set; }
        public string FilmeId { get; set; }
        public string CinemaId { get; set; }
    }
}
