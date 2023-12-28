using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Service;
using Entity;
using Microsoft.Extensions.Logging;
using AutoMapper;
using DTO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IuserService _UsersServ;
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;

        public UserController(IuserService UsersServ, ILogger<UserController> logger, IMapper mapper)
        {
            _UsersServ = UsersServ;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        async public Task<ActionResult<UserSaveDTO>> Get([FromQuery] string email, [FromQuery] string password)
        {
           

            _logger.LogInformation("user email " + email);
            try
            {
                User user = await _UsersServ.GetUser(email, password);
                UserSaveDTO res = _mapper.Map<User, UserSaveDTO>(user);
                return res;
            }
            catch(Exception e)
            {
                _logger.LogError("error", e.Message, e.StackTrace);
                return NotFound();
            }
            return NotFound();
        }


        [HttpPost]

        async public Task<ActionResult<UserSaveDTO>> Post([FromBody] UserDTO User)
        {
            
            var resMap = _mapper.Map<UserDTO, User>(User);
            User userRes = await _UsersServ.Post(resMap);
            var UserAfter = _mapper.Map<User, UserSaveDTO> (userRes);
            return Ok(UserAfter);
        }
        
        [HttpPut("{id}")]
        async public Task<UserSaveDTO> Put(int id,[FromBody] UserDTO User)
        {
            var resMap = _mapper.Map<UserDTO, User>(User);
            await _UsersServ.UpdateUser(id,resMap);
            var UserAfter = _mapper.Map<User, UserSaveDTO>(resMap);
            return UserAfter;
        }


    }
}
