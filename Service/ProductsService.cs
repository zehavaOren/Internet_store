using Zxcvbn;
using DataRepository;
using Entity;

namespace Service
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _Productsrepository;

        public ProductsService(IProductsRepository Productsrep)
        {
            _Productsrepository = Productsrep;
        }

        async public Task<Product[]> getAllProducts()
        {
            return await _Productsrepository.getAllProducts();
        }

        public async Task<Product[]> Get(int[]? categoryId, string? name, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy, string? direction)
        {
            Product[] products = await _Productsrepository.Get(categoryId, name, priceFrom, priceTo, start, limit, orderBy, direction);
            return products;
        }


    }
}