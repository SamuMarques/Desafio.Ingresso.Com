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
    public class FilmeAppService : IFilmeAppService
    {
        private readonly IFilmeService _filmeService;

        public FilmeAppService(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        public void Create(FilmeModel filme)
        {
            _filmeService.Create(Mapper.Map<FilmeModel, Filme>(filme));
        }

        public void Delete(string id)
        {
            _filmeService.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<FilmeModel> GetAll()
        {
            return Mapper.Map<List<Filme>, List<FilmeModel>>(_filmeService.GetAll().ToList());
        }

        public FilmeModel GetById(string id)
        {
            return Mapper.Map<Filme, FilmeModel>(_filmeService.GetById(id));
        }

        public void Update(string id, FilmeModel filme)
        {
            _filmeService.Update(id, Mapper.Map<FilmeModel, Filme>(filme));
        }
    }
}
