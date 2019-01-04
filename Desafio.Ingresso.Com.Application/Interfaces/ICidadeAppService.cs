using Desafio.Ingresso.Com.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Ingresso.Com.Application.Interfaces
{
    public interface ICidadeAppService : IDisposable
    {
        IEnumerable<CidadeModel> GetAll();
        CidadeModel GetById(string id);
        void Create(CidadeModel cidade);
        void Update(string id, CidadeModel cidade);
        void Delete(string id);
    }
}
