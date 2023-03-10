namespace Domain.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; } = new();

    public Customer()
    {
        
    }
    public Customer(int id, string firstname, string lastname, string address, string phone, string email)
    {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        Address = address;
        Phone = phone;
        Email = email;
    }
}