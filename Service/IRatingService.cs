using Entity;

namespace Service
{
    public interface IRatingService
    {
        Task AddRatingDeatils(Rating rating);
    }
}