using Assignment.Core.Helpers;
using Assignment.Domain.Interfaces.IRepositories;
using Assignment.Domain.Models;

//using Assignment.Repository.Models;
using Assignment.Repository.Repositories;
using Assignment.REST.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;


namespace Assignment.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#if ProducesConsumes
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
#endif
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customersRepository;
        public CustomersController(ICustomerRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var response = _customersRepository.GetByID("ALFKI");
            //return Ok(response.Data);
            return Ok();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }

}
