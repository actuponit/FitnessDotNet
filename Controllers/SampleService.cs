
using FitnessDotNet.DBConfig;
using FitnessDotNet.User;
using FItnessDotNet.DBConfig;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace FitnessDotNet.Controllers
{
    public interface ISample{
        public void get();
    }
    class SampleService: MongoDBService, ISample {
        private readonly IMongoCollection<UserModel> _collection;
        public SampleService(IOptions<MongoDBSettings> options) : base(options)
        {
            _collection = GetCollection<UserModel>("Users");
        }
        public void get() {
            Console.WriteLine(_collection.Find(_ => true));
        }

    }
}