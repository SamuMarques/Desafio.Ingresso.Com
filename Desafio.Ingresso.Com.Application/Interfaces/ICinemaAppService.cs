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
        void Create(CinemaCrudModel cinema);
        void Update(string id, CinemaCrudModel cinema);
        void Delete(string id);
    }
}
