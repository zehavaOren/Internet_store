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

        public async Task<Category[]> GetAllCategories()

        {

           /* var list = (from Categories in _dbContext.Categories
                        select Categories).ToArray<Category>();*/
            List<Category> Categorys = await _dbContext.Categories
               .Include(category => category.Products).ToListAsync();


            return Categorys.ToArray();

        }



 //       async public Task<Category[]> Get(int[]? categoriesIds)
 //       {
 //           /*  int i=0;
 //            Category[] list=new Category[categoriesIds.Length];
 //             while (categoriesIds[i] != null)
 //             {
 //                 list= (from Category in _dbContext.Categories
 //                          where categoriesIds[i] == Category.Id
 //                          select Category).ToArray();
 //                 i++;
 //             }
 //            return list;
 //*/

 //           var list = (from Category in _dbContext.Categories
 //                   where categoriesIds[0] == Category.Id
 //                   select Category).ToArray();
 //           return list;
 //       }

    }
}