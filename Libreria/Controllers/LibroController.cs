using Libreria.Core.Entities;
using Libreria.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Libreria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly ILibro _libro;

        public LibroController(ILibro libro)
        {
            _libro = libro;
        }


        // GET: api/<LibroController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> Get()
        {
            try
            {
                IEnumerable<Libro> libros = await _libro.GetLibroAsync();
                return Ok(libros);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }


        // GET api/<AutoresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Libro>> Get(int id)
        {
            try
            {
                Libro libro = await _libro.GetLibrossByIdAsync(id);
                return Ok(libro);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<AutoresController>
        [HttpPost]
        public async Task<ActionResult<Libro>> Post([FromBody] Libro libro)
        {
            try
            {
                return Ok(await _libro.CreateLibrosAsync(libro));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // PUT api/<AutoresController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Libro>> Put(int id, [FromBody] Libro libro)
        {
            try
            {
                return Ok(await _libro.EditLbrosAsync(id, libro));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // DELETE api/<AutoresController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _libro.DeleteLibrosAsync(id);
                return Ok();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
