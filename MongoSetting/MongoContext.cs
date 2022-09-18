using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DeliveryProtocol.MongoSetting
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoContext(IOptions<MongoDBSettings> dbOptions)
        {
            var settings = dbOptions.Value;
            _client = new MongoClient(settings.ConnectionURI);
            _database = _client.GetDatabase(settings.DatabaseName);
        }

        public IMongoClient Client => _client;

        public IMongoDatabase Database => _database;
    }
}

