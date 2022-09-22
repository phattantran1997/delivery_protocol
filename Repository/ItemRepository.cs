using System;
using DeliveryProtocol.Entities;
using DeliveryProtocol.MongoSetting;

namespace DeliveryProtocol.Repository
{

    public interface IItemRepository: IRepository<Item> { }
    public class ItemRepository : MongoRepository<Item>, IItemRepository
    {
        public ItemRepository(MongoContext context): base(context)
        {
        }
    }
}

