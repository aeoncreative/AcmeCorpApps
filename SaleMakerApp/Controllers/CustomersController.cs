using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaleMakerApp.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleMakerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        //M$ scaffolded methods, modified to allow for proper return objects for some methods
        //can do object and child level update, including contact - can separate into CustomerContacts depending on need

        // GET: api/<CustomersController>
        [HttpGet]
        public Entities.Models.Customer Get()
        {
            return new Entities.Models.Customer();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Entities.Models.Customer Get(int id)
        {
            return new Entities.Models.Customer() { Id = id };
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Entities.Models.Customer customer)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Entities.Models.Customer customer)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
