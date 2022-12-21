using Entity;

namespace DataRepository
{
    public interface ICategoryRepository
    {
        Task<Category[]> GetAllCategories();
        //Task<Category[]> Get(int[]? categoriesIds);
    }
}