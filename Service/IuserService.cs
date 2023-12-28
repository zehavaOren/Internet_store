using Entity;

namespace Service
{
    public interface IuserService
    {
        Task<User?> GetUser(string email, string password);
        Task<User> Post(User user);
        Task UpdateUser(int id, User user);
    }
}