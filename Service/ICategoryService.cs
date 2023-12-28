using Entity;

namespace Service
{
    public interface ICategoryService
    {
        /*Task<Category[]> Get(int[]? categoriesIds);*/
        Task<IEnumerable<Category?>> getAllCategories();
    }
}