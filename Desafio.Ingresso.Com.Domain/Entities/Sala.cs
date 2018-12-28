using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Entities
{
    public class Sala
    {
        public string IdSala { get; set; }
        public string Identificador { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
