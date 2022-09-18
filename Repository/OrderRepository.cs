using System.Linq.Expressions;
using DeliveryProtocol.Entities;

using DeliveryProtocol.MongoSetting;
using MongoDB.Driver;

namespace DeliveryProtocol.Repository
{
    public interface IOrderRepository : IRepository<Order> { }

    public class OrderRepository : MongoRepository<Order>, IOrderRepository
    {
        public OrderRepository(MongoContext context) : base(context)
        {
        }
    }

}

