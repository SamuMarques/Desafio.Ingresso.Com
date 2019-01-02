
namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sala
    {
        public string Id { get; set; }
        public string Identificador { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
