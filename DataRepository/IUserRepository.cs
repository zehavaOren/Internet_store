using Entity;

namespace DataRepository
{
    public interface IUserRepository
    {
<<<<<<< HEAD
        Task<User?> GetUser(string EMAIL, string PASSWORD);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(int id, User user);
=======
        Task<User> Get(int ID);
        Task<User> Get(string EMAIL, string PASSWORD);
        Task<User> Post(User user);
        /* Task<User> Put(int id, User user);*/
        Task updateUser(int userId, User newUser);
>>>>>>> c6efb4aa2fc06c8706859400b6eb2677bfc8a4a7
    }
}