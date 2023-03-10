using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController:ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("GET")]
    public List<OrderDto> GetOrders()
    {
        return _orderService.GetOrders();
    }
    [HttpGet("GETBYID")]
    public Order GetOrderID(int id)
    {
        return _orderService.GetOrderId(id);
    }
    [HttpGet("GetAllDatas")]
    public List<OrderDto> GetOrderDate()
    {
        return _orderService.GetOrders();
    }
    [HttpPost("ADD")]
    public bool AddOrder(Order order)
    {
        _orderService.AddOrder(order);
        return true;
    }
    [HttpPut("UpdateCustomer")]
    public bool UpdateOrder(Order order)
    {
        _orderService.UpdateOrder(order);
        return true;
    }
    [HttpDelete("Delete")]
    public void DeleteOrder(int id)
    {
        _orderService.DeleteOrder(id);
    }
}