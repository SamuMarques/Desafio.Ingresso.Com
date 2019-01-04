using System;
using System.Collections.Generic;
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
        public string Identificador { get; set; }
    }
}
