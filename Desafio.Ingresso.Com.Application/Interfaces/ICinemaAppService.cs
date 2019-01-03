using Desafio.Ingresso.Com.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Interfaces
{
    public interface ICinemaAppService : IDisposable
    {
        IEnumerable<CinemaModel> GetAll();
        CinemaModel GetById(string id);
        void Create(CinemaModel cinema);
        void Update(string id, CinemaModel cinema);
        void Delete(string id);
    }
}
