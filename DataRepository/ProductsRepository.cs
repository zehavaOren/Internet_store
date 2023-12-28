using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;

namespace DataRepository
{
    public class ProductsRepository : IProductsRepository
    {
        private web_dbContext _dbContext;
        public ProductsRepository(web_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product[]> getAllProducts()
        {
            var list = (from Product in _dbContext.Products
                        select Product).ToArray<Product>();
            return list;
        }
        public async Task<Product[]> Get(int[]? categoryId, string? name, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy = "name", string? direction = "desc")

        {
            var qurey = _dbContext.Products.Where(product => (name == null ? (true) : (product.Name.Contains(name)))
              && ((priceFrom == null) ? (true) : (product.Price >= priceFrom))
              && ((categoryId.Length == 0) ? (true) : (categoryId.Contains(product.Category)))
              && ((priceTo == null) ? (true) : (product.Price <= priceTo))).OrderBy(product => orderBy).Include(p => p.CategoryNavigation).ToArray();
            Console.WriteLine(qurey);
           
            List<Product> products =  qurey.ToList();
            return products.ToArray();
        }

}
}