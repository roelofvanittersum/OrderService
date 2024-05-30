using Rvi.OrderApi.Domain.Database;
using Rvi.OrderApi.Domain.Messages;
using Rvi.OrderApi.Domain.Models;
using Rvi.OrderApi.Domain.Services;

namespace Rvi.OrderApi.Services;

public class OrderService : IOrderService
{
    private readonly IOrderDataService _orderDataService;
    private readonly IQueueService _queueService;

    public OrderService(IOrderDataService orderDataService, IQueueService queueService)
    {
        _orderDataService = orderDataService;
        _queueService = queueService;
    }

    public async Task<string> Create(Order order)
    {
        string orderId = await _orderDataService.CreateOrder(order);
        
        // Enqueue created event
        await _queueService.EnqueueAsync(new OrderCreatedMessage(orderId));

        return orderId;
    }

    public Task<OrderStatus> GetStatus(string orderId)
    {
        return _orderDataService.GetStatus(orderId);
    }

    public Task HandleOrder(string orderId)
    {
        // Process the order message, this should be done in steps.
        // Each step will update the state of the order and publishes a new message signaling a finished state.
        // Another consumer will pick-up the message from the queue database and so on until we have a finalized order
        throw new NotImplementedException();
    }
}