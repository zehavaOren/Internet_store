using Entity;

namespace DataRepository
{
    public interface IUserRepository
    {
        Task<User> Get(int ID);
        Task<User> Get(string EMAIL, string PASSWORD);
        Task<User> Post(User user);
        /* Task<User> Put(int id, User user);*/
        Task updateUser(int userId, User newUser);
    }
}