namespace Rvi.OrderApi.Domain.Models;

public class Order
{
    public string Id { get; set; }
    public string ProductId { get; set; }
    public Customer Customer { get; set; }
    public Address Address { get; set; }
    public BankAccount BankAccount { get; set; }
}