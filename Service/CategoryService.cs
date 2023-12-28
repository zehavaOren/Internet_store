using Zxcvbn;
using DataRepository;
using Entity;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _Categoryrepository;

        public CategoryService(ICategoryRepository Categoryrep)
        {
            _Categoryrepository = Categoryrep;
        }
        //
        async public Task<IEnumerable<Category?>> getAllCategories()
        {
            var res= await _Categoryrepository.GetAllCategories();
            return res;
        }
    }
}