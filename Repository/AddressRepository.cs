using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using DeliveryProtocol.Entities;
using DeliveryProtocol.MongoSetting;
using MongoDB.Driver;

namespace DeliveryProtocol.Repository
{
    public interface IAddressRepository : IRepository<Address>
    {
        public Task<IEnumerable<Address>> FilterAddress(string character);
        public Task<Address> FindByAddressDetail(string address);

    }
    public class AddressRepository : MongoRepository<Address>, IAddressRepository
    {
        public AddressRepository(MongoContext mongoContext) : base(mongoContext)
        {

        }
        public async Task<Address> FindByAddressDetail(string address)
        {
            var filter = Builders<Address>.Filter.Where((x => x.AddressDetail == address));
            return (await DbSet.FindAsync(filter)).FirstOrDefault();

        }
        public async Task<IEnumerable<Address>> FilterAddress(string character)
        {
            var filter = Builders<Address>.Filter.Where((x => x.AddressDetail.Contains(character)));
            return (await DbSet.FindAsync(filter)).ToEnumerable();

        }
    }
}

