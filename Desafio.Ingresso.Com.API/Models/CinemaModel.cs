using System.Collections.Generic;

namespace Desafio.Ingresso.Com.API.Models
{
    public class CinemaModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        public virtual IEnumerable<SalaModel> Salas { get; set; }
    }
}
