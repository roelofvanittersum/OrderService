using Rvi.OrderAPI.Model.Models;

namespace Rvi.OrderApi.Mappers;

public static class OrderCreatedResponseV1Mapper
{
    public static OrderCreatedResponseV1 Map(string orderId)
    {
        return new OrderCreatedResponseV1
        {
            OrderId = orderId
        };
    }
}