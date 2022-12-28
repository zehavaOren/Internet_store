using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Service;
using Entity;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IuserService _UsersServ;

        public UserController(IuserService UsersServ)
        {
            _UsersServ = UsersServ;
        }

        [HttpGet]
        async public Task<ActionResult<IEnumerable<User>>> Get([FromQuery] string email, [FromQuery] string password)
        {
            if (await _UsersServ.Get(email, password) != null)
                return Ok(await _UsersServ.Get(email, password));
            return NotFound();
        }


        // POST api/<Users>
        [HttpPost]

        async public Task<ActionResult<User>> Post([FromBody] User Users)
        {
            User u = await _UsersServ.Post(Users);
            return u;
        }
        
        [HttpPut("{id}")]
        async public Task<User> Put( [FromBody] User Users)
        {
            await _UsersServ.Put(Users.Id, Users);
            return Users;
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        async public Task Delete(int id)
        {
        }


    }
}
