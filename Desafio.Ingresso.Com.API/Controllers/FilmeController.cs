using System;
using System.Collections.Generic;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Ingresso.Com.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeAppService _filmeAppService;

        public FilmeController(IFilmeAppService filmeAppService)
        {
            _filmeAppService = filmeAppService;
        }

        // GET: api/Filme
        [HttpGet]
        public IEnumerable<FilmeModel> Get()
        {
            return _filmeAppService.GetAll();
        }

        // GET: api/Filme/5
        [HttpGet("{id}")]
        public FilmeModel Get(string id)
        {
            return _filmeAppService.GetById(id);
        }

        // POST: api/Filme
        [HttpPost]
        public IActionResult Post([FromBody] FilmeModel filme)
        {
            try
            {
                _filmeAppService.Create(filme);

                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);

            }
        }

        // PUT: api/Filme/Id
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] FilmeModel filme)
        {
            try
            {
                filme.Id = id;
                _filmeAppService.Update(id, filme);
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
            _filmeAppService.Delete(id);
        }
    }
}
