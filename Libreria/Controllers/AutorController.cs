using Libreria.Core.Entities;
using Libreria.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutor _autor;

        public AutorController(IAutor autor)
        {
            _autor = autor;
        }

        // GET: api/<AutoresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> Get()
        {
            try
            {
                IEnumerable<Autor> autores = await _autor.GetAutoresAsync();
                return Ok(autores);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }

        // GET api/<AutoresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autor>> Get(int id)
        {
            try
            {
                Autor autor = await _autor.GetAutoresByIdAsync(id);
                return Ok(autor);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<AutoresController>
        [HttpPost]
        public async Task<ActionResult<Autor>> Post([FromBody] Autor autor)
        {
            try
            {
                return Ok(await _autor.CreateAutorAsync(autor));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // PUT api/<AutoresController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Autor>> Put(int id, [FromBody] Autor autor)
        {
            try
            {
                return Ok(await _autor.EditAutorAsync(id, autor));
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
                await _autor.DeleteAutorAsync(id);
                return Ok();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
