namespace Domain.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime OrderFulfilled { get; set; }
    public int CustomerId { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new();
    public Customer? Customer { get; set; }

    public Order()
    {
        
    }
    public Order(int id, DateTime orderplaced, DateTime orderfulfilled, int customerid)
    {
        Id = id;
        OrderPlaced = orderplaced;
        OrderFulfilled = orderfulfilled;
        CustomerId = customerid;
    }
}