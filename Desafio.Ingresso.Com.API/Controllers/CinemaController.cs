using System;
using System.Collections.Generic;
using Desafio.Ingresso.Com.Application.Interfaces;
using Desafio.Ingresso.Com.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Ingresso.Com.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaAppService _cinemaAppService;

        public CinemaController(ICinemaAppService cinemaAppService)
        {
            _cinemaAppService = cinemaAppService;
        }

        // GET: api/Cinema
        [HttpGet]
        public IEnumerable<CinemaModel> Get()
        {
            return _cinemaAppService.GetAll();
        }

        // GET: api/Cinema/5
        [HttpGet("{id}")]
        public CinemaModel Get(string id)
        {
            return _cinemaAppService.GetById(id);
        }

        // POST: api/Cinema
        [HttpPost]
        public IActionResult Post([FromBody] CinemaCrudModel cinema)
        {
            try
            {
                _cinemaAppService.Create(cinema);
                return Ok(cinema);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Cinema/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] CinemaCrudModel cinema)
        {
            cinema.Id = id;
            _cinemaAppService.Update(id, cinema);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cinemaAppService.Delete(id);
        }

    }
}
