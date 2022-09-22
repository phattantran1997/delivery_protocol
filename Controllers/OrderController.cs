using System.Net;
using DeliveryProtocol.Entities;
using DeliveryProtocol.Entities.Request;
using DeliveryProtocol.Entities.Response;
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
    public async Task<IEnumerable<Order>> Get()
    {
        var vm = await _service.GetAll();
        return vm;
    }

    [HttpGet("{id}")]
    public async Task<OrderResponseModel> Get(string id)
    {
        var vm = await _service.GetById(id);
        return vm;
    }
    [HttpPost]
    [Route("create")] 
    public async Task<OrderResponseModel> CreateNewOrder([FromBody] NewOrderRequest request)
    {
        var vm = await _service.CreateNewOrder(request);

        Response.StatusCode = (int)HttpStatusCode.Created;

        return new OrderResponseModel
        {
            Order = vm,
            IsSuccess = true
        };
    }
    [HttpPut("{id}")]
    public async Task<OrderResponseModel> PutAsync(string id, [FromBody] NewOrderRequest request)
    {

        var vm = await _service.UpdateOrderAsync(id,request);
        if (vm != null)
        {
            return new OrderResponseModel
            {
                Order = vm,
                IsSuccess = true
            };
        }
        else
        {
            return new OrderResponseModel
            {
                Order = null,
                IsSuccess = false
            };
        }
    }
    [HttpDelete("{id}")]
    public async Task DeleteAsync(string id)
    {
        await _service.DeleteOrderById(id);
    }

}

