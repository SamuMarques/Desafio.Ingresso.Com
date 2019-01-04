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
    public class CinemaAppService : ICinemaAppService
    {
        private readonly ICinemaService _cinemaService;
        private readonly ICidadeService _cidadeService;

        public CinemaAppService(ICinemaService cinemaService, ICidadeService cidadeService)
        {
            _cinemaService = cinemaService;
            _cidadeService = cidadeService;
        }

        public void Create(CinemaCrudModel cinema)
        {
            _cinemaService.Create(Mapper.Map<CinemaCrudModel, Cinema>(cinema));
        }

        public void Delete(string id)
        {
            _cinemaService.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CinemaModel> GetAll()
        {
            var lst = new List<CinemaModel>();
            var cinemas = _cinemaService.GetAll().ToList();

            foreach (var cinema in cinemas)
            {
                var model = Mapper.Map<Cinema, CinemaModel>(cinema);
                model.Cidade = Mapper.Map<Cidade, CidadeModel>(_cidadeService.GetById(cinema.CidadeId));
                lst.Add(model);
            }

            return lst;
        }

        public CinemaModel GetById(string id)
        {
            var cinema = _cinemaService.GetById(id);
            var model = Mapper.Map<Cinema, CinemaModel>(cinema);
            model.Cidade = Mapper.Map<Cidade, CidadeModel>(_cidadeService.GetById(cinema.CidadeId));

            return model;
        }

        public void Update(string id, CinemaCrudModel cinema)
        {
            _cinemaService.Update(id, Mapper.Map<CinemaCrudModel, Cinema>(cinema));
        }
    }
}
