using AutoMapper;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsService _ProductServ;
        private readonly IMapper _mapper;


        public ProductsController(IProductsService ProductServ, IMapper mapper)
        {
            _ProductServ = ProductServ;
            _mapper = mapper;
        }
       
       [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get([FromQuery]int[]? categoryId, [FromQuery] string? name, [FromQuery] int? priceFrom, [FromQuery] int? priceTo, [FromQuery] int? start, [FromQuery] int? limit, [FromQuery] string? orderBy,[FromQuery] string? direction)
        {
            Product[] products = await _ProductServ.Get(categoryId, name, priceFrom, priceTo, start, limit, orderBy, direction);
            var res= _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(products);
            return res;
        }
        
    }
}
