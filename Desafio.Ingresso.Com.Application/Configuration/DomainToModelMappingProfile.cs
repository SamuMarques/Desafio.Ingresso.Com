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
            CreateMap<FilmeModel, Filme>();
            CreateMap<Sala, SalaModel>();
            CreateMap<Cinema, CinemaModel>().ForMember(x => x.Cidade, opt => opt.Ignore());
            CreateMap<Cinema, CinemaCrudModel>();
            CreateMap<Sessao, SessaoModel>()
                .ForMember(x => x.Cinema, opt => opt.Ignore())
                .ForMember(x => x.Filme, opt => opt.Ignore())
                .ForMember(x => x.Sala, opt => opt.Ignore()); 
            CreateMap<Sessao, SessaoCrudModel>();
            CreateMap<Cidade, CidadeModel>();
            CreateMap<Cidade, Cidade>();
        }
    }
}
