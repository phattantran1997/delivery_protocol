using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DeliveryProtocol.Entities
{
    [BsonIgnoreExtraElements]
    public class Order : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("gender")]
        public string Gender { get; set; } = string.Empty;

        [BsonElement("date")]
        public string DateCreated { get; set; } = string.Empty;

    }
}

