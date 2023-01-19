using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController:ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("GET")]
    public List<CustomerDto> GetCustomers()
    {
        return _customerService.GetCustomers();
    }
    [HttpGet("GetProductByName")]
    public List<CustomerDto> GetCustomerByName(string name)
    {
        return _customerService.GetCustomerByName(name);
    }
    [HttpGet("GETBYID")]
    public Customer GetCustomerID(int id)
    {
        return _customerService.GetCustomerID(id);
    }
    
    [HttpPost("ADD")]
    public bool AddUser(CustomerDto customer)
    {
        _customerService.AddCustomer(customer);
       return true;
    }
    [HttpPut("UpdateCustomer")]
    public bool UpdateCustomer(CustomerDto customer)
    {
        _customerService.UpdateCustomer(customer);
        return true;
    }
    [HttpDelete("Delete")]
    public void DeleteCustomer(int id)
    {
        _customerService.DeleteCustomer(id);
    }
}