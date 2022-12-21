using Entity;

namespace DataRepository
{
    public interface IOrderRepository
    {
         Task AddOrder(Order order);
    }
}