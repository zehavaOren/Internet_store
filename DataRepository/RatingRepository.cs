using Entity;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;

namespace DataRepository
{
    public class RatingRepository : IRatingRepository
    {
        private web_dbContext _dbContext;
        public RatingRepository(web_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddRatingDetails(Rating rating)

        {
            await _dbContext.Rating.AddAsync(rating);
            await _dbContext.SaveChangesAsync();
        }
    }
}