using Desafio.Ingresso.Com.Domain.Entities;
using AutoMapper;
using Desafio.Ingresso.Com.Application.Model;

namespace Desafio.Ingresso.Com.Application.Configuration
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {
            CreateMap<Filme, FilmeModel>();
            CreateMap<Sala, SalaModel>();
            CreateMap<Cinema, CinemaModel>();
        }
    }
}
