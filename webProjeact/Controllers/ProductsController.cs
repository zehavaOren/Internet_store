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

        public ProductsController(IProductsService ProductServ)
        {
            _ProductServ = ProductServ;
        }
        // GET: api/<ProductController>
      /*  [HttpGet]
          async public Task<Product[]> Get()
          {
             Product []products=await _ProductServ.getAllProducts();
              return products;
          }*/
         

        // GET api/<ProductController>/5
       [HttpGet]
        public async Task<Product[]> Get([FromQuery]int[]? categoryId, [FromQuery] string? name, [FromQuery] int? priceFrom, [FromQuery] int? priceTo, [FromQuery] int? start, [FromQuery] int? limit, [FromQuery] string? orderBy,[FromQuery] string? direction)
        {
            Product[] products = await _ProductServ.Get(categoryId, name, priceFrom, priceTo, start, limit, orderBy, direction);
            return products;
        }
      
    }
}
