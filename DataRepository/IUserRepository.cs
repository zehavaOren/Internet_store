using Entity;

namespace DataRepository
{
    public interface IUserRepository
    {
        Task<User?> GetUser(string EMAIL, string PASSWORD);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(int id, User user);
    }
}