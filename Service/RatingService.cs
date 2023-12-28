using DataRepository;
using Entity;

namespace Service
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _RatingRepository;

        public RatingService(IRatingRepository Orderrep)
        {
            _RatingRepository = Orderrep;
        }
        public async Task AddRatingDeatils(Rating rating)
        {
            await _RatingRepository.AddRatingDetails(rating);

        }
    }
}



    
