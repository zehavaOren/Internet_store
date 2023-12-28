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

        async public Task<User?> GetUser(string email, string password)
        {
            User user= await _Usersrep.GetUser(email, password);
                return user;
        }
        async public Task<User> Post(User user)
        {
            User newUser= await _Usersrep.AddUser(user);
            return newUser;
        }

        async public Task UpdateUser(int id, User user)
        {
            await _Usersrep.UpdateUser(id, user);
            return;
        }

    }
}