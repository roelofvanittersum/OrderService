namespace Rvi.OrderApi.Domain.Database;

public interface IQueueDataService
{
    Task EnqueueAsync<T>(T message);
    Task<T> DequeueAsync<T>();
}