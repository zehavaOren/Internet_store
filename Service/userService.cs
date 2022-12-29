using Zxcvbn;
using DataRepository;
using Entity;

namespace Service
{
    public class UsersService : IuserService
    {
        private readonly IUserRepository _Usersrep;

        public UsersService(IUserRepository Usersrep)
        {
            _Usersrep = Usersrep;
        }

        async public Task<User> Get(int id)
        {
            return await _Usersrep.Get(id);
        }

        async public Task<User> Get(string email, string password)
        {
            User user= await _Usersrep.Get(email, password);
           /* if (user == null)
                return null;
            else*/
                return user;
        }
        async public Task<User> Post(User user)
        {
            User newUser= await _Usersrep.Post(user);
            return newUser;
        }

        async public Task Put(int id, User user)
        {
            await _Usersrep.updateUser(id, user);
            return;
        }

    }
}