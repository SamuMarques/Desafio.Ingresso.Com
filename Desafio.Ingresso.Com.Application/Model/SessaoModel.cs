using Desafio.Ingresso.Com.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class SessaoModel
    {
        public string Id { get; set; }
        [RegularExpression("^([0-9][0-9][0-9]|[0-9][0-9]|[0-9]):([0-5][0-9])$", ErrorMessage = "Informe um horário válido (hh:mm)")]
        public string Hora { get; set; }
        [Required(ErrorMessage = "Preencha o campo dia da semana")]
        public virtual IEnumerable<DiasDaSemana> DiasDaSemana { get; set; }
        [Required(ErrorMessage = "Preencha o campo data de fim")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Preencha o campo data de fim")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataFim { get; set; }
        public virtual SalaModel Sala { get; set; }
        public virtual FilmeModel Filme { get; set; }
        public virtual CinemaModel Cinema { get; set; }

    }
}
