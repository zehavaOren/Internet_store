using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;

namespace DataRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private web_dbContext _dbContext;
        public CategoryRepository(web_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category?>> GetAllCategories()

        {
            var list = (from Categories in _dbContext.Categories
                        select Categories).Include(category => category.Products).ToList();
            return list;

        }

    }
}