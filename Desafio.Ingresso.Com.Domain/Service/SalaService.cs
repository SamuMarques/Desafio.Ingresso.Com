using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Domain.Service
{
    public class SalaService : ServiceBase<Sala>, ISalaService
    {
        private readonly ISalaRepository _salaRepository;

        public SalaService(ISalaRepository salaRepository)
            :base(salaRepository)
        {
            _salaRepository = salaRepository;
        }

    }
}
