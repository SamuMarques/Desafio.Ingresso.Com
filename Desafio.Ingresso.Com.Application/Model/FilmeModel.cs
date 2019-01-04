using System.ComponentModel.DataAnnotations;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class FilmeModel
    {
        
        public string Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo classificação")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Classificacao { get; set; }
        [Required(ErrorMessage = "Preencha o campo gênero")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Preencha o campo sinopse")]
        [MaxLength(4000, ErrorMessage = "Máximo 4000 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Sinopse { get; set; }
        [Required(ErrorMessage = "Preencha o campo duração")]
        public int Duracao { get; set; }
    }
}
