using Entity;

namespace Service
{
    public interface IProductsService
    {
        Task<Product[]> Get(int[]? categoryId, string? description, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy, string? direction);
        Task<Product[]> getAllProducts();
    }
}