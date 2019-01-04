using Desafio.Ingresso.Com.Application.Model;
using System;
using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Application.Interfaces
{
    public interface ISessaoAppService : IDisposable
    {
        SessaoModel GetById(string id);
        IEnumerable<SessaoModel> GetAll();
        void Create(SessaoCrudModel sessao);
        void Update(string id, SessaoCrudModel sessao);
        void Delete(string id);
    }
}
