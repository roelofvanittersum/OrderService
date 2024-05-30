using Microsoft.Extensions.Hosting;
using Rvi.OrderApi.Domain.Messages;
using Rvi.OrderApi.Domain.Services;

namespace Rvi.OrderApi.Services;

public class OrderCreatedConsumer: BackgroundService
{
    private readonly IQueueService _queueService;
    private readonly IOrderService _orderService;

    public OrderCreatedConsumer(IQueueService queueService, IOrderService orderService)
    {
        _queueService = queueService;
        _orderService = orderService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var message = await _queueService.DequeueAsync<OrderCreatedMessage>();
            if (message != null)
            {
                await _orderService.HandleOrder(message.OrderId);
            }
            
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }
}