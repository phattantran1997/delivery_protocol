using System;
using DeliveryProtocol.Entities;
using DeliveryProtocol.Entities.Request;
using DeliveryProtocol.Entities.Response;
using DeliveryProtocol.MongoSetting;
using DeliveryProtocol.Repository;
using MongoDB.Driver;

namespace DeliveryProtocol.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAll();

        Task<OrderResponseModel> GetById(string ID);

        Task<Order> CreateNewOrder( NewOrderRequest newOrderRequest);

        Task DeleteOrderById(string id);

        Task<Order> UpdateOrderAsync(string id, NewOrderRequest model);

    }
    public class OrderService : IOrderService
    {
        private IAddressRepository _addressRepository;
        private IOrderRepository _orderRepository;
        private IItemRepository _itemRepository;
        public OrderService(MongoContext dbContext)
        {
            _orderRepository = new OrderRepository(dbContext);
            _addressRepository = new AddressRepository(dbContext);
            _itemRepository = new ItemRepository(dbContext);
        }

        public async Task<Order> CreateNewOrder(NewOrderRequest request)
        {
           request.DeliveryPoints.Add(request.Pickup);
            foreach(AddressRequest addressRequest in request.DeliveryPoints)
            {
                Address address = _addressRepository.FindByAddressDetail(addressRequest.AddressDetail).Result;
                if (address == null)
                {
                    Address newaddress = _addressRepository.Add(new Address(addressRequest)).Result;
                }
            }

            Order neworder = new Order();
            neworder.PickupPoint = new Address(request.Pickup);
            neworder.DeliveryPoints = request.DeliveryPoints.Select(x=> new Address(x)).ToList();
            neworder.Items = request.Items.Select(x => new Item(x)).ToList();
            neworder.UpdatedAt = DateTime.UtcNow;
            var result = await _orderRepository.Add(neworder);

            foreach (ItemRequest itemRequest in request.Items)
            {
                Item newItem = new Item(itemRequest);
                newItem.OrderId = result.Id;
                await _itemRepository.Add(newItem);

            }
            return result;
        }

        public async Task DeleteOrderById(string id)
        {
            await _orderRepository.Remove(id);
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            var orders = await _orderRepository.GetAll();
            return orders;
        }

        public async Task<OrderResponseModel> GetById(string ID)
        {
            var order = await _orderRepository.GetById(ID);
            return new OrderResponseModel {
                Order = order,
                IsSuccess = true
            };
        }

        public async Task<Order> UpdateOrderAsync(string id, NewOrderRequest request)
        {

            Order updatedOrder = new Order();
            updatedOrder.PickupPoint = new Address(request.Pickup);
            updatedOrder.DeliveryPoints = request.DeliveryPoints.Select(x => new Address(x)).ToList();
            updatedOrder.Items = request.Items.Select(x => new Item(x)).ToList();
            updatedOrder.startTime = request.startTime;
            updatedOrder.endTime = request.endTime;

           return await _orderRepository.Update(id,updatedOrder);

        }
    }
}

