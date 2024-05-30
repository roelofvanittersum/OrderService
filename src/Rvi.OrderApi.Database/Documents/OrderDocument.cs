using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Rvi.OrderApi.Database.Documents;

public class OrderDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    [BsonElement("createdDate")]
    public DateTime CreatedDate { get; set; }
    
    [BsonElement("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }

    [BsonElement("payload")] 
    public string OrderPayload { get; set; }
}