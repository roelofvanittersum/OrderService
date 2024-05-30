using Rvi.OrderApi.Database.Documents;
using Rvi.OrderApi.Domain.Models;

namespace Rvi.OrderApi.Database.Mappers;

public static class OrderDocumentMapper
{
    public static OrderDocument Map(Order source)
    {
        if (source == null)
            return null;

        return new OrderDocument
        {
            CreatedDate = DateTime.UtcNow,
            Status = OrderStates.CREATED,
            OrderPayload = null
        };
    }
}