using System;
using MongoDB.Bson.Serialization.Attributes;

namespace DeliveryProtocol.Entities.Response
{
    public class OrderResponseModel : BaseResponseModel
    {
        public Order? Order { get; set; }
    }
}

