using Entity;

namespace Service
{
    public interface IPasswordService
    {
        Task<int> ChekPaswword(string password);
    }
}