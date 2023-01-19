using Domain.Models;

public class OrderService
{

  private readonly DataContext _context;
  public OrderService(DataContext context)
  {
    _context = context;
  }
  public List<OrderDto> GetOrders()
  {
    return _context.Orders.Select(x => new OrderDto()
    {
      Id = x.Id,
      CustomerId = x.CustomerId,
      FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName),
    }).ToList();
  }
  public Order GetOrderId(int id)
  {
    return _context.Orders.FirstOrDefault(x => x.Id == id);
  }
  public List<OrderDto> GetOrdersByDate(DateTime date)
  {
        
    return _context.Orders
      .Where(x=>x.OrderPlaced.Date == date.Date)
      .Select(x => new OrderDto()
      {
        Id = x.Id,
        CustomerId = x.CustomerId,
        FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName)
      }).ToList();
  }
  public int AddOrder(Order order)
  {
    _context.Add(order);
    var result = _context.SaveChanges();
    return result;
  }
  public void UpdateOrder(Order order)
  {
    var updated = new Order(order.Id,  order.OrderPlaced ,order.OrderFulfilled,order.CustomerId);
    _context.Orders.Update(order);
    _context.SaveChanges();
  }
  public int DeleteOrder(int id) 
  {
    var order = _context.Orders.Find(id);
    _context.Orders.Remove(order);
    return _context.SaveChanges();
  }

}