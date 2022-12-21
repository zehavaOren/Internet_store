using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IOrderService _OrderServ;

        public OrdersController(IOrderService CategoryServ)
        {
            _OrderServ = CategoryServ;
        }
      

        [HttpPost]
        async public Task<ActionResult> Post([FromBody] Order order)
        {

            _OrderServ.AddOrder(order);
            return Ok();
        }



    }
}

