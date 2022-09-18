using System;
using DeliveryProtocol.Entities;
using DeliveryProtocol.MongoSetting;
using DeliveryProtocol.Repository;

namespace DeliveryProtocol.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAll();

    }
    public class OrderService : IOrderService
    {
        private readonly MongoContext _dbContext;
        private IOrderRepository _orderRepository;

        public OrderService(MongoContext dbContext)
        {
            _dbContext = dbContext;
            _orderRepository = new OrderRepository(_dbContext);
        }
        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _orderRepository.GetAll();
        }
    }
}

