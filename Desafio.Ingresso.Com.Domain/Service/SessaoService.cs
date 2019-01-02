using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;

namespace Desafio.Ingresso.Com.Domain.Service
{
    public class SessaoService : ServiceBase<Sessao>, ISessaoService
    {
        private readonly ISessaoRepository _sessaoRepository;

        public SessaoService(ISessaoRepository sessaoRepository)
            :base(sessaoRepository)
        {
            _sessaoRepository = sessaoRepository;
        }
    }
}
