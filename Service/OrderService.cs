using DataRepository;
using Entity;
using Microsoft.Extensions.Logging;

namespace Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IProductsRepository _ProductsRepository;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository Orderrep, IProductsRepository ProductsRepository, ILogger<OrderService> logger)
        {
            _OrderRepository = Orderrep;
            _ProductsRepository = ProductsRepository;
            _logger = logger;
        }
        public async Task AddOrder(Order order)
        {
            Product[] products = await _ProductsRepository.getAllProducts();
            int sum = 0;
            foreach (var item in order.OrderItems)
                foreach (var item2 in products)
                {
                    if (item.Productid == item2.Id)
                    {
                        sum += item2.Price;
                        break;
                    }
                }
            {

            }
            if (sum != order.Price)
            {
                _logger.LogError("some one try to change amount of order!!");

            }
            order.Price = sum;
            await _OrderRepository.AddOrder(order);

        }
    }
}



    
