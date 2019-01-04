using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class CidadeModel
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }
    }
}
