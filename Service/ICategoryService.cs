using Entity;

namespace Service
{
    public interface ICategoryService
    {
        /*Task<Category[]> Get(int[]? categoriesIds);*/
        Task<Category[]> getAllCategories();
    }
}