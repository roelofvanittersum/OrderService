namespace Rvi.OrderApi.Domain.Services;

public interface IQueueService
{
    Task EnqueueAsync<T>(T message);
    Task<T> DequeueAsync<T>();
}