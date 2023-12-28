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

<<<<<<< HEAD
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
=======
        public async Task updateUser(int userId, User newUser)
        {
            _dbContext.Users.Update(newUser);
            await _dbContext.SaveChangesAsync();
        }
        /* async public Task<User> Put(int id, User user)
         {
             User userToUpdate = await _dbContext.Users.FindAsync(id);
             if (userToUpdate == null)
             {
                 return null;
             }
             _dbContext.Entry(userToUpdate).CurrentValues.SetValues(user);
             await _dbContext.SaveChangesAsync();
             return user;
         }*/
>>>>>>> c6efb4aa2fc06c8706859400b6eb2677bfc8a4a7


            
        }

    }
}