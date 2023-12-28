using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;

namespace DataRepository
{
    public class UserRepository :IUserRepository
    {
        private web_dbContext _dbContext;
        public UserRepository(web_dbContext dbContext)
        {
            _dbContext = dbContext;
        }
  

         public async Task<User> GetUser(string EMAIL, string PASSWORD)

        {
            var list = (from User in _dbContext.Users
                        where User.Password == PASSWORD && User.Email == EMAIL
                        select User).ToArray<User>();
            return list.FirstOrDefault();
        }

         public async Task<User> AddUser(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        async public Task<User> UpdateUser(int id, User user)
        {
            var userFound = _dbContext.Users.Find(id);
            if (userFound == null)
            {
                return null;
            }
            _dbContext.Entry(userFound).CurrentValues.SetValues(user);
            _dbContext.SaveChanges();
            return user;
            // _dbContext.Users.Update(user);
            //await _dbContext.SaveChangesAsync();
            //return user;


            
        }

    }
}