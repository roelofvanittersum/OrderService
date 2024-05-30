using Rvi.OrderApi.Domain.Models;

namespace Rvi.OrderApi.Domain.Database;

public interface IOrderDataService
{
    Task<string> CreateOrder(Order order);
    Task<OrderStatus> GetStatus(string orderId);
}