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
  
        [HttpPost]
        async public Task<ActionResult<int>> post([FromBody] string password)
        {
            throw new Exception("ffffffffff");
            int resPassword= await _passwordServ.ChekPaswword(password);
            if (resPassword > 0)
            {
                return resPassword;
            }
            else
                return BadRequest(resPassword);
        }
    }
}
