namespace Rvi.OrderApi.Domain.Messages;

public class OrderCreatedMessage: MessageBase
{
    public OrderCreatedMessage() { }
    public OrderCreatedMessage(string orderId)
    {
        OrderId = orderId;
    }
    
    public string OrderId { get; set; }
}