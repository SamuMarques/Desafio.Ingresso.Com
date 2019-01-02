using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Ingresso.Com.API.Models;
using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Ingresso.Com.API.Controllers
{
    [Route("api/Filme")]
    [ApiController]
    public class FilmeController : ControllerBase
    {

        private readonly IFilmeService _filmeService;

        public FilmeController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        // GET: api/Filme
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return _filmeService.GetAll();
        }

        // GET: api/Filme/5
        [HttpGet("{id}")]
        public Filme Get(string id)
        {
            return _filmeService.GetById(id);
        }

        // POST: api/Filme
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            try
            {
                _filmeService.Create(filme);

                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);

            }
        }

        // PUT: api/Filme/Id
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Filme filme)
        {
            try
            {
                filme.Id = id;
                _filmeService.Update(id, filme);
                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _filmeService.Delete(id);
        }
    }
}
