using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Model
{
    public class SalaModel
    {
        public string IdSala { get; set; }
        public string Identificador { get; set; }
        public virtual CinemaModel Cinema { get; set; }
    }
}
