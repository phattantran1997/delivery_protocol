using System;
using DeliveryProtocol.Ultils;
using MongoDB.Bson.Serialization.Attributes;

namespace DeliveryProtocol.Entities
{
    public class OrderDetail : BaseEntity
    {

        [BsonElement("orderId")]
        public string OrderId { get; set; } = string.Empty;

        [BsonElement("item")]
        public List<Item> Items { get; set; } = new List<Item>();

        [BsonElement("deliveryPoint")]
        public Address DeliveryPoints { get; set; } = new Address();

    }
}

