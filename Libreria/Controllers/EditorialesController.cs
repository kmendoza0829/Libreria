using Libreria.Core.Entities;
using Libreria.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Libreria.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EditorialesController : ControllerBase
    {

        private readonly IEditorial _editorial;

        public EditorialesController(IEditorial editorial)
        {
            _editorial = editorial;
        }

        // GET: api/<EditorialesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editorial>>> Get()
        {
            try
            {
                IEnumerable<Editorial> editoriales = await _editorial.GetEditorialesAsync();
                return Ok(editoriales);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
            
        }

        // GET api/<EditorialesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Editorial>> Get(int id)
        {
            try
            {
                Editorial editorial =  await _editorial.GetEditorialesByIdAsync(id);
                return Ok(editorial);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<EditorialesController>
        [HttpPost]
        public async Task<ActionResult<Editorial>> Post([FromBody] Editorial editorial)
        {
            try
            {
                return Ok(await _editorial.CreateEditorialAsync(editorial));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // PUT api/<EditorialesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Editorial>> Put(int id, [FromBody] Editorial editorial)
        {
            try
            {
                return Ok(await _editorial.EditEditorialAsync(id, editorial));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // DELETE api/<EditorialesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _editorial.DeleteEditorialAsync(id);
                return Ok();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
