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

        public CinemaAppService(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        public void Create(CinemaModel cinema)
        {
            _cinemaService.Create(Mapper.Map<CinemaModel, Cinema>(cinema));
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
            return Mapper.Map<List<Cinema>, List<CinemaModel>>(_cinemaService.GetAll().ToList());
        }

        public CinemaModel GetById(string id)
        {
            return Mapper.Map<Cinema, CinemaModel>(_cinemaService.GetById(id));
        }

        public void Update(string id, CinemaModel cinema)
        {
            _cinemaService.Update(id, Mapper.Map<CinemaModel, Cinema>(cinema));
        }
    }
}
