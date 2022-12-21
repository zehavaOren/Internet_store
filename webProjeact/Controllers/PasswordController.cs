using Microsoft.AspNetCore.Mvc;
using Service;
using Zxcvbn;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {

        private readonly IPasswordService _passwordServ;

        public PasswordController(IPasswordService PasswordServ)
        {
            _passwordServ = PasswordServ;
        }
  

        // POST api/<PasswordController>
        [HttpPost]
        async public Task<int> post([FromBody] string password)
        {
           
            return await _passwordServ.Post(password);
        }

      /*  [HttpPost]
        public int Post([FromBody] string code)
        {
            Result result = Zxcvbn.Core.EvaluatePassword(code);
            return result.Score;
        }*/
    }
}
