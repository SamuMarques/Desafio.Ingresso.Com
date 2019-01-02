using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;

namespace Desafio.Ingresso.Com.Domain.Service
{
    public class CinemaService : ServiceBase<Cinema>, ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaService(ICinemaRepository cinemaRepository)
            :base(cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }
    }
}
