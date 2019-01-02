using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;

namespace Desafio.Ingresso.Com.Domain.Service
{
    public class FilmeService : ServiceBase<Filme>, IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
            : base(filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
    }
}
