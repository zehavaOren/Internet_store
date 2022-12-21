using Entity;

namespace Service
{
    public interface IProductsService
    {
        Task<Product[]> Get(int[]? categoryId, string? name, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy, string? direction);
        Task<Product[]> getAllProducts();
    }
}