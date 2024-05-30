using Rvi.OrderApi.Domain.Models;
using Rvi.OrderAPI.Model.Models;
using Order = Rvi.OrderApi.Domain.Models.Order;

namespace Rvi.OrderApi.Mappers;

public static class OrderModelMapper
{
    public static Order Map(CreateOrderV1 source)
    {
        return new Order
        {
            ProductId = source.ProductId,
            Customer = new Customer(),
            Address = new Address(),
            BankAccount = new BankAccount()
        };
    }
}