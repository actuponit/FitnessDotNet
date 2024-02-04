using Microsoft.Extensions.Options;
using MongoDB.Driver;
using FitnessDotNet.DBConfig;

namespace FItnessDotNet.DBConfig
{
    public class MongoDBService
    {
        private readonly IMongoClient _client;
        protected readonly IMongoDatabase database;
        public MongoDBService(IOptions<MongoDBSettings> options)
        {
            _client = new MongoClient(options.Value.ConnectionUrl);
            database = _client.GetDatabase(options.Value.DatabaseName);
        }

        protected IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }
    }
}