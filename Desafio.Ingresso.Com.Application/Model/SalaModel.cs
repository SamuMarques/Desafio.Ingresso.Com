using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class SalaModel
    {
        public SalaModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo sinopse")]
        [MaxLength(120, ErrorMessage = "Máximo 500 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Identificador { get; set; }
    }
}
