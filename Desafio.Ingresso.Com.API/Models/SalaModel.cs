
namespace Desafio.Ingresso.Com.API.Models
{
    public class SalaModel
    {
        public string IdSala { get; set; }
        public string Identificador { get; set; }
        public virtual CinemaModel Cinema { get; set; }
    }
}
