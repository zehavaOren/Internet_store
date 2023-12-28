using AutoMapper;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace webProjeact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _CategoryService;
        private readonly IMapper _mapper;


        public CategoriesController(ICategoryService CategoryService, IMapper mapper)
        {
            _CategoryService = CategoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> Get()
        {
            var categories= await _CategoryService.getAllCategories();
            var res = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(categories);
            return res;
        }
        
    }
}
