using DeliveryProtocol.Entities;
using DeliveryProtocol.Repository;
using DeliveryProtocol.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryProtocol.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : Controller
{
    //private readonly IOrderRepository _db;
    private readonly IOrderService _service;
    public OrderController(IOrderService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<Order>> Index()
    {
        var vm = await _service.GetAll();
        return vm;
    }

}

