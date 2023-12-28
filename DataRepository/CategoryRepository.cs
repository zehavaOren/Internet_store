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
<<<<<<< HEAD
            var list = (from Categories in _dbContext.Categories
                        select Categories).Include(category => category.Products).ToList();
            return list;
=======

           /* var list = (from Categories in _dbContext.Categories
                        select Categories).ToArray<Category>();*/
            List<Category> Categorys = await _dbContext.Categories
               .Include(category => category.Products).ToListAsync();


            return Categorys.ToArray();
>>>>>>> c6efb4aa2fc06c8706859400b6eb2677bfc8a4a7

        }

    }
}