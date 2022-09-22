using System;
using DeliveryProtocol.Entities;
using DeliveryProtocol.Entities.Request;
using DeliveryProtocol.MongoSetting;
using DeliveryProtocol.Repository;

namespace DeliveryProtocol.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAll();

        Task<Address> GetById(string ID);

        Task<Address> CreateNewOrder(AddressRequest newAddress);

        Task DeleteOrderById(string id);

        Task<Address> UpdateOrderAsync(string id, AddressRequest newAddress);

        Task<IEnumerable<Address>> FindAddress(string address);
    }
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepository;
        public AddressService(MongoContext mongoContext)
        {
            _addressRepository = new AddressRepository(mongoContext);
        }

        public Task<Address> CreateNewOrder(AddressRequest newAddress)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Address>> FindAddress(string address)
        {
            var rs =  await _addressRepository.FilterAddress(address);
            return rs;
        }

        public Task<IEnumerable<Address>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateOrderAsync(string id, AddressRequest newAddress)
        {
            throw new NotImplementedException();
        }
    }
}

