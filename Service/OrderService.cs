using DataRepository;
using Entity;

namespace Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository Orderrep)
        {
            _OrderRepository = Orderrep;
        }


        public async Task AddOrder(Order order)
        {
            await _OrderRepository.AddOrder(order);
    

        }
    }
}



    
