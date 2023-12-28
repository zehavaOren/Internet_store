using Zxcvbn;
using DataRepository;
using Entity;

namespace Service
{
    public class PasswordService : IPasswordService
    {
        private readonly IUserRepository _userrep;

        public PasswordService(IUserRepository userrep)
        {
            _userrep = userrep;
        }

        async public Task<int> ChekPaswword(string password)
        {
            Result result = Zxcvbn.Core.EvaluatePassword(password);
            return result.Score;
        }
        
    }
}