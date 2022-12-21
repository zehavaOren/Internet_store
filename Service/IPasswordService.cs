using Entity;

namespace Service
{
    public interface IPasswordService
    {
        Task<int> Post(string password);
    }
}