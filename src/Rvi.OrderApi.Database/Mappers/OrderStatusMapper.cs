using Rvi.OrderApi.Database.Documents;
using Rvi.OrderApi.Domain.Models;

namespace Rvi.OrderApi.Database.Mappers;

public static class OrderStatusMapper
{
    public static OrderStatus Map(OrderDocument source)
    {
        if (source == null)
            return null;

        return new OrderStatus
        {
            OrderId = source.Id,
            Status = source.Status
        };
    }
}