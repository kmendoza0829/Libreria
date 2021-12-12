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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EditorialesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EditorialesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EditorialesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
