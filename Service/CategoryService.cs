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

        async public Task<Category[]> getAllCategories()
        {
            return await _Categoryrepository.GetAllCategories();
        }

       /* public async Task<Category[]> Get(int[]? categoriesIds)
        {
            Category []res = await _Categoryrepository.Get(categoriesIds);
            return res;
        }*/


    }
}