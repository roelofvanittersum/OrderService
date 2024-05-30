using Rvi.OrderApi.Domain.Database;
using Rvi.OrderApi.Domain.Services;

namespace Rvi.OrderApi.Services;

public class QueueService : IQueueService
{
    private readonly IQueueDataService _queueDataService;

    public QueueService(IQueueDataService queueDataService)
    {
        _queueDataService = queueDataService;
    }

    public Task EnqueueAsync<T>(T message)
    {
        return _queueDataService.EnqueueAsync<T>(message);
    }

    public Task<T> DequeueAsync<T>()
    {
        return _queueDataService.DequeueAsync<T>();
    }
}