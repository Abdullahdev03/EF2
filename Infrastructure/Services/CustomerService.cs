using Domain.Models;

public class CustomerService
{

  private readonly DataContext _context;
  public CustomerService(DataContext context)
  {
    _context = context;
  }
  public List<CustomerDto> GetCustomers()
  {
    return _context.Customers.Select(x=>new CustomerDto(x.Id,x.FirstName,x.LastName,x.Email,x.Phone,x.Address)).ToList();
  }
  public List<CustomerDto> GetCustomerByName(string name)
  {
    return _context.Customers. Where(x => x.FirstName.ToLower().Contains(name.ToLower())).
        Select(x => new CustomerDto(x.Id, x.FirstName)).ToList();
  }
  public Customer GetCustomerID(int id)
  {
    return _context.Customers.FirstOrDefault(x => x.Id == id);
  }
  public int AddCustomer(CustomerDto customer)
  {
    _context.Add(customer);
    var result = _context.SaveChanges();
    return result;
  }
  public void UpdateCustomer(CustomerDto customer)
  {
    var updated = new Customer(customer.Id, customer.FirstName, customer.LastName, customer.Address, customer.Phone, customer.Email);
    _context.Customers.Add(updated);
    _context.SaveChanges();
  }
  public int DeleteCustomer(int id) 
  {
    var customer = _context.Customers.Find(id);
    _context.Customers.Remove(customer);
    return _context.SaveChanges();
  }
  

}