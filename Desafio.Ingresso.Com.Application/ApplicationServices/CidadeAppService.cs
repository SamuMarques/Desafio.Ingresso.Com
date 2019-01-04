using AutoMapper;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Application.Model;
using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio.Ingresso.Com.Application.ApplicationServices
{
    public class CidadeAppService : ICidadeAppService
    {
        private readonly ICidadeService _cidadeService;

        public CidadeAppService(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }

        public void Create(CidadeModel cidade)
        {
            _cidadeService.Create(Mapper.Map<CidadeModel, Cidade>(cidade));
        }

        public void Delete(string id)
        {
            _cidadeService.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CidadeModel> GetAll()
        {
            return Mapper.Map<List<Cidade>, List<CidadeModel>>(_cidadeService.GetAll().ToList());
        }

        public CidadeModel GetById(string id)
        {
            return Mapper.Map<Cidade, CidadeModel>(_cidadeService.GetById(id));
        }

        public void Update(string id, CidadeModel cidade)
        {
            _cidadeService.Update(id, Mapper.Map<CidadeModel, Cidade>(cidade));
        }
    }
}
