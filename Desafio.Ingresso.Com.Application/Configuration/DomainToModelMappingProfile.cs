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
            CreateMap<Sessao, SessaoModel>()
                .ForMember(x => x.Cinema, opt => opt.Ignore())
                .ForMember(x => x.Filme, opt => opt.Ignore())
                .ForMember(x => x.Sala, opt => opt.Ignore()); 
            CreateMap<Sessao, SessaoCrudModel>();
                
        }
    }
}
