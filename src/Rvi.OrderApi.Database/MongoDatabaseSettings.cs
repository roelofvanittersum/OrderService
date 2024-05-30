namespace Rvi.OrderApi.Database;

public class MongoDatabaseSettings
{
    public string Database { get; set; }
    public string ConnectionString { get; set; }
    public bool DisableCacheForIndexes { get; set; }
}