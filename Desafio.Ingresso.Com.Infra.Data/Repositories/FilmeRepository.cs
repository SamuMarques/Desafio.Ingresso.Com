
using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces;
using MongoDB.Driver;

namespace Desafio.Ingresso.Com.Infra.Data.Repositories
{
    public class FilmeRepository : RepositoryBase<Filme>, IFilmeRepository
    {
    }
}
