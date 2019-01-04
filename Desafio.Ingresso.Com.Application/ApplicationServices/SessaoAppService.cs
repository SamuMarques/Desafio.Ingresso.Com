using AutoMapper;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Application.Model;
using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Desafio.Ingresso.Com.Application.ApplicationServices
{
    public class SessaoAppService : ISessaoAppService
    {
        private readonly ISessaoService _sessaoService;
        private readonly ICinemaService _cinemaService;
        private readonly IFilmeService _filmeService;

        public SessaoAppService(ISessaoService sessaoService, ICinemaService cinemaService, IFilmeService filmeService)
        {
            _sessaoService = sessaoService;
            _cinemaService = cinemaService;
            _filmeService = filmeService;
        }

        public void Create(SessaoCrudModel model)
        {
            Sessao sessao = Mapper.Map<SessaoCrudModel, Sessao>(model);

            if (sessao.CreateIsValid())
            {
                _sessaoService.Create(sessao);
            }
            else
            {
                throw new Exception("Revise os Campos enviados.");
            }
        }

        public void Delete(string id)
        {
            _sessaoService.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<SessaoModel> FindAll(string idCidade)
        {
            var lst = new List<SessaoModel>();

            var sessoes = _sessaoService.GetAll().ToList();
            foreach (var sessao in sessoes)
            {
                var model = Mapper.Map<Sessao, SessaoModel>(sessao);
                var cinema = _cinemaService.GetById(sessao.CinemaId);

                if (!string.IsNullOrWhiteSpace(idCidade) && cinema.CidadeId != idCidade)
                {
                    continue;
                }
                model.Cinema = Mapper.Map<Cinema, CinemaModel>(cinema);
                
                model.Filme = Mapper.Map<Filme, FilmeModel>(_filmeService.GetById(sessao.FilmeId));
                model.Sala = model.Cinema.Salas.Where(x => x.Id == Guid.Parse(sessao.SalaId)).FirstOrDefault();
                lst.Add(model);
            }

            return lst;
        }

        public SessaoModel GetById(string id)
        {
            var sessao = _sessaoService.GetById(id);

            var model = Mapper.Map<Sessao, SessaoModel>(sessao);
            if (model != null)
            {
                model.Cinema = Mapper.Map<Cinema, CinemaModel>(_cinemaService.GetById(sessao.CinemaId));
                model.Filme = Mapper.Map<Filme, FilmeModel>(_filmeService.GetById(sessao.FilmeId));
                model.Sala = model.Cinema.Salas.Where(x => x.Id == Guid.Parse(sessao.SalaId)).FirstOrDefault();
            }
            else
            {
                throw new Exception("Sessão não encontrada.");
            }

            return model;
        }

        public void Update(string id, SessaoCrudModel sessao)
        {
            _sessaoService.Update(id, Mapper.Map<SessaoCrudModel, Sessao>(sessao));
        }
    }
}
