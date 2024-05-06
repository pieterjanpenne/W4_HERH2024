using Assignment.Domain.Interfaces.IRepositories;
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

    public class MenuController : ControllerBase
    {
        private readonly MenuRepository _menuRepository;

        public MenuController(MenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        // GET: api/<MenuController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] MenuParameters parameters)
        {
            var menus = _menuRepository.GetAll(parameters);

            var metaData = new
            {
                menus.TotalCount,
                menus.PageSize,
                menus.CurrentPage,
                menus.TotalPages,
                menus.HasNext,
                menus.HasPrevious
            };

            Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(metaData));

            return Ok(menus);
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        // POST api/<AdminController>
        [HttpPost]
        public void Post([FromBody] MenuDTO value)
        {
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}