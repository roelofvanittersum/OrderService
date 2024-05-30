using Rvi.OrderAPI.Model.Models;
using OrderStatus = Rvi.OrderApi.Domain.Models.OrderStatus;

namespace Rvi.OrderApi.Mappers;

public static class OrderStatusV1Mapper
{
    public static OrderStatusV1 Map(OrderStatus source)
    {
        return source == null ? null : new OrderStatusV1
        {
            OrderId = source.OrderId,
            Status = source.Status
        };
    }
}