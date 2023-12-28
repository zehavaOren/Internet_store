using AutoMapper;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IOrderService _OrderService;
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;
        private readonly ILogger<OrdersController> _logger;


        public OrdersController(IOrderService OrderService, IMapper mapper, ILogger<OrdersController> logger, IProductsService productService)
        {
            _OrderService = OrderService;
            _mapper = mapper;
            _logger = logger;
            _productsService= productService;

        }

        [HttpPost]
        async public Task<ActionResult> Post([FromBody] OrderDTO order)
        {
            var OrderMap= _mapper.Map<OrderDTO ,Order>(order);
            await _OrderService.AddOrder(OrderMap);
            return Ok();
            
        }

    }
}

