using System.ComponentModel.DataAnnotations;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class FilmeModel
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(120, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo classificação")]
        [MaxLength(120, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Classificacao { get; set; }
        [Required(ErrorMessage = "Preencha o campo gênero")]
        [MaxLength(120, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Preencha o campo sinopse")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sinopse { get; set; }
        [Required(ErrorMessage = "Preencha o campo duração")]
        public int Duracao { get; set; }
    }
}
