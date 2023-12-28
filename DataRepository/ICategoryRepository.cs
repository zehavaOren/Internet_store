using Entity;

namespace DataRepository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category?>> GetAllCategories();
        //Task<Category[]> Get(int[]? categoriesIds);
    }
}