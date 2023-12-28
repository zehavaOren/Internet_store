using Entity;

namespace DataRepository
{
    public interface IRatingRepository
    {
        Task AddRatingDetails(Rating rating);
    }
}