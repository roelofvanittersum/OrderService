using System.Text;
using Rvi.OrderApi.Domain.Database;
using Rvi.OrderApi.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Rvi.OrderApi.Database.Documents;
using Rvi.OrderApi.Database.Mappers;

namespace Rvi.OrderApi.Database;

public class OrderDataService: IOrderDataService
{
    private IMongoDatabase MongoDatabase { get; set; }

    public OrderDataService(IOptions<MongoDatabaseSettings> databaseSetting)
    {
        IMongoClient mongoClient = new MongoClient(databaseSetting.Value.ConnectionString);
        MongoDatabase = mongoClient.GetDatabase(databaseSetting.Value.Database, new MongoDB.Driver.MongoDatabaseSettings
        {
            ReadEncoding = new UTF8Encoding(false, false)
        });
    }
    
    public async Task<string> CreateOrder(Order order)
    {
        OrderDocument document = OrderDocumentMapper.Map(order);
        await MongoDatabase.GetCollection<OrderDocument>("orders").InsertOneAsync(document);

        return document.Id;
    }

    public async Task<OrderStatus> GetStatus(string orderId)
    {
        IAsyncCursor<OrderDocument> result = await MongoDatabase.GetCollection<OrderDocument>("orders").FindAsync(x => x.Id == orderId);
        OrderDocument document = result.FirstOrDefault();

        return OrderStatusMapper.Map(document);
    }
}