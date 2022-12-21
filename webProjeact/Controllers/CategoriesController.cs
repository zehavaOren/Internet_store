using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _CategoryServ;

        public CategoriesController(ICategoryService CategoryServ)
        {
            _CategoryServ = CategoryServ;
        }
        [HttpGet]
        public async Task<Category[]> Get()
        {
            return await _CategoryServ.getAllCategories();
        }

    }
}
