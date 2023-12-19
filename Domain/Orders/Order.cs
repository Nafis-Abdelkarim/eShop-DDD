namespace Domain.Orders;

public class Order
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
}
