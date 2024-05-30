using System.Text;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Rvi.OrderApi.Database;

public class QueueDataService : Rvi.OrderApi.Domain.Database.IQueueDataService
{
    private IMongoDatabase MongoDatabase { get; set; }
    public QueueDataService(IOptions<MongoDatabaseSettings> databaseSetting)
    {
        IMongoClient mongoClient = new MongoClient(databaseSetting.Value.ConnectionString);
        MongoDatabase = mongoClient.GetDatabase(databaseSetting.Value.Database, new MongoDB.Driver.MongoDatabaseSettings
        {
            ReadEncoding = new UTF8Encoding(false, false)
        });
    }
    
    public async Task EnqueueAsync<T>(T message)
    {
        var document = new BsonDocument
        {
            { "message", BsonValue.Create(message) },
            { "timestamp", DateTime.UtcNow }
        };

        await MongoDatabase.GetCollection<BsonDocument>("orderQueue").InsertOneAsync(document);
    }

    public async Task<T> DequeueAsync<T>()
    {
        var filter = new BsonDocument();
        var sort = Builders<BsonDocument>.Sort.Ascending("timestamp");
        var update = Builders<BsonDocument>.Update.Set("status", "dequeued");
        var options = new FindOneAndUpdateOptions<BsonDocument>
        {
            Sort = sort,
            ReturnDocument = ReturnDocument.After
        };

        var result = await MongoDatabase.GetCollection<BsonDocument>("orderQueue").FindOneAndUpdateAsync(filter, update, options);

        if (result != null)
        {
            var bsonValue = result["message"] as BsonValue;
            if (bsonValue != null)
            {
                return (T)Convert.ChangeType(bsonValue.AsString, typeof(T));
            }
        }

        return default; // Queue is empty
    }
}