using Desafio.Ingresso.Com.Application.Model;
using System;
using System.Collections.Generic;

namespace Desafio.Ingresso.Com.Application.Interfaces
{
    public interface IFilmeAppService : IDisposable
    {
        IEnumerable<FilmeModel> GetAll();
        FilmeModel GetById(string id);
        void Create(FilmeModel filme);
        void Update(string id, FilmeModel filme);
        void Delete(string id);
    }
}
