using Entity;

namespace Service
{
    public interface IuserService
    {
        Task<User> Get(int id);
        Task<User> Get(string email, string password);
        Task<User> Post(User user);
        Task Put(int id, User user);
    }
}