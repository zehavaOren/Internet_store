using Entity;
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



        public async Task<Product[]> Get(int[]? categoryId, string? description, int? priceFrom, int? priceTo, int? start, int? limit, string? orderBy = "name", string? direction = "desc")

        {
            /*var list = (from User in _dbContext.Users
                        where User.Password == PASSWORD && User.Email == EMAIL
                        select User).ToArray<User>();
            Console.WriteLine(list);
            return list.FirstOrDefault();*/
            return null;
        }


    }
}