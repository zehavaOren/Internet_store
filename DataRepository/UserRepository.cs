using Entity;
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


        async public Task<User> Get(int ID)

        {
            User res = await _dbContext.Users.FindAsync(ID);
            await _dbContext.SaveChangesAsync();
            return res;

        }

         public async Task<User> Get(string EMAIL, string PASSWORD)

        {
            var list = (from User in _dbContext.Users
                        where User.Password == PASSWORD && User.Email == EMAIL
                        select User).ToArray<User>();
            return list.FirstOrDefault();
        }

         public async Task<User> Post(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            Console.WriteLine(user);
            Console.WriteLine("post");
            return user;
        }

        async public Task<User> Put(int id, User user)
        {
            User userToUpdate = await _dbContext.Users.FindAsync(id);
            if (userToUpdate == null)
            {
                return null;
            }
            _dbContext.Entry(userToUpdate).CurrentValues.SetValues(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }


    }
}