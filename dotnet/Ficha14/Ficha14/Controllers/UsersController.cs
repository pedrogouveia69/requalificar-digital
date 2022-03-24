using Ficha14.Models;
using Ficha14.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ficha14.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user != null)
            {
                User newUser = service.Create(user);
                return CreatedAtRoute("GetByISBN", newUser);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{userName, password}")]
        public IActionResult Get(string userName, string password)
        {
            User? user = service.Get(userName, password);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
