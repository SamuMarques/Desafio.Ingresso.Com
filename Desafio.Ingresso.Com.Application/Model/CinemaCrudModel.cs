using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class CinemaCrudModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }
        public string CidadeId { get; set; }
        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Logradouro { get; set; }
        
        public virtual IEnumerable<SalaModel> Salas { get; set; }
    }
}
