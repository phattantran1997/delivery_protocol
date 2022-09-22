using System;
namespace DeliveryProtocol.Entities.Request
{
    public class NewOrderRequest
    {
        public AddressRequest Pickup { get; set; } = new AddressRequest();
        public List<AddressRequest> DeliveryPoints { get; set; } = new List<AddressRequest>();
        public List<ItemRequest> Items { get; set; } = new List<ItemRequest>();
        public long startTime { get; set; } = 0;

        public long endTime { get; set; } = 0;

        public NewOrderRequest(AddressRequest pickup, List<AddressRequest> deliveryPoints, List<ItemRequest> items, long startTime, long endTime)
        {
            Pickup = pickup;
            DeliveryPoints = deliveryPoints;
            Items = items;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}

