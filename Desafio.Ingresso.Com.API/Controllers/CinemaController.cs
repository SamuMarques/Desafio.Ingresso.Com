using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Ingresso.Com.Domain.Entities;
using Desafio.Ingresso.Com.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Ingresso.Com.API.Controllers
{
    [Route("api/Cinema")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;

        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        // GET: api/Cinema
        [HttpGet]
        public IEnumerable<Cinema> Get()
        {
            return _cinemaService.GetAll();
        }

        // GET: api/Cinema/5
        [HttpGet("{id}")]
        public Cinema Get(string id)
        {
            return _cinemaService.GetById(id);
        }

        // POST: api/Cinema
        [HttpPost]
        public IActionResult Post([FromBody] Cinema cinema)
        {
            try
            {
                _cinemaService.Create(cinema);
                return Ok(cinema);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Cinema/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Cinema cinema)
        {
            cinema.Id = id;
            _cinemaService.Update(id, cinema);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cinemaService.Delete(id);
        }
    }
}
