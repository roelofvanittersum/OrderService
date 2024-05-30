using Rvi.OrderApi.Domain.Models;

namespace Rvi.OrderApi.Domain.Services;

public interface IOrderService
{
    public Task<string> Create(Order order);
    Task<OrderStatus> GetStatus(string orderId);
    Task HandleOrder(string orderId);
}