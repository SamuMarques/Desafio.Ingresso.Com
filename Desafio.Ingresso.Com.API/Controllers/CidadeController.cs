using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Application.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Ingresso.Com.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeAppService _cidadeAppService;
        public CidadeController(ICidadeAppService cidadeAppService)
        {
            _cidadeAppService = cidadeAppService;
        }

        // GET: api/Cidade
        [HttpGet]
        public IEnumerable<CidadeModel> Get()
        {
            return _cidadeAppService.GetAll();
        }

        // GET: api/Cidade/5
        [HttpGet("{id}")]
        public CidadeModel Get(string id)
        {
            return _cidadeAppService.GetById(id);
        }

        // POST: api/Cidade
        [HttpPost]
        public IActionResult Post([FromBody] CidadeModel cidade)
        {
            try
            {
                _cidadeAppService.Create(cidade);
                return Ok(cidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Cidade/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] CidadeModel cidade)
        {
            try
            {
                cidade.Id = id;
                _cidadeAppService.Update(id, cidade);
                return Ok(cidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cidadeAppService.Delete(id);
        }
    }
}
