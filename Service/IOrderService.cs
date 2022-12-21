using Entity;

namespace Service
{
    public interface IOrderService
    {
        Task AddOrder(Order order);
    }
}