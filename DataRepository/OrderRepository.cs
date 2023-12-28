using Entity;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;

namespace DataRepository
{
    public class OrderRepository : IOrderRepository
    {
        private web_dbContext _dbContext;
        public OrderRepository(web_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> AddOrder(Order order)

        {
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }
    }
}