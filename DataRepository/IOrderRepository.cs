using Entity;

namespace DataRepository
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
    }
}