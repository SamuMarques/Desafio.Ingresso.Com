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
    public class SessaoController : ControllerBase
    {
        private readonly ISessaoAppService _sessaoAppService;
        public SessaoController(ISessaoAppService sessaoAppService)
        {
            _sessaoAppService = sessaoAppService;
        }

        // GET: api/Sessao
        [HttpGet]
        [Route("/ObterSessoes/{idCidade}")]
        public IEnumerable<SessaoModel> GetAll(string idCidade)
        {
            return _sessaoAppService.FindAll(idCidade);
        }

        // GET: api/Sessao/5
        [HttpGet("{id}")]
        public SessaoModel Get(string id)
        {
            return _sessaoAppService.GetById(id);
        }

        // POST: api/Sessao
        [HttpPost]
        public IActionResult Post([FromBody] SessaoCrudModel sessao)
        {
            try
            {
                _sessaoAppService.Create(sessao);
                return Ok(sessao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Sessao/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] SessaoCrudModel sessao)
        {
            sessao.Id = id;
            _sessaoAppService.Update(id, sessao);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _sessaoAppService.Delete(id);
        }
    }
}
