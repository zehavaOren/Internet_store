using Entity;

namespace DataRepository
{
    public interface IProductsRepository
    {
        Task<Product[]> getAllProducts();
        Task<Product[]> Get(int[]? categoryId, string? name, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy = "name", string? direction = "desc");
    }
}