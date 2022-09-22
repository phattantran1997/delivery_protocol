using System;
using DeliveryProtocol.Entities.Request;
using DeliveryProtocol.Ultils;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DeliveryProtocol.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
           
        }
       
        public Order(Address pickup, List<Item> items, List<Address> deliveryPoints)
        {
            PickupPoint = pickup;
            Items = items;
            DeliveryPoints = deliveryPoints;
        }

        [BsonElement("pickup")]
        public Address PickupPoint { get; set; } = new Address();

        [BsonElement("items")]
        public List<Item> Items { get; set; } = new List<Item>();

        [BsonElement("deliveryPoints")]
        public List<Address> DeliveryPoints { get; set; } = new List<Address>();

        public long startTime { get; set; } = 0;
        public long endTime { get; set; } = 0;

    }
}

