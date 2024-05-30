using System.Net;
using Microsoft.AspNetCore.Mvc;
using Rvi.OrderApi.Domain.Services;
using Rvi.OrderApi.Mappers;
using Rvi.OrderAPI.Model.Controllers;
using Rvi.OrderAPI.Model.Models;
using OrderStatus = Rvi.OrderApi.Domain.Models.OrderStatus;

namespace Rvi.OrderApi.Controllers;

public class OrderApiController : OrderV1ApiController
{
    private readonly IOrderService _orderService;

    public OrderApiController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    public override async Task<IActionResult> CreateOrder(CreateOrderV1 createOrderV1)
    {
        string orderId = await _orderService.Create(OrderModelMapper.Map(createOrderV1));
        return new JsonResult(OrderCreatedResponseV1Mapper.Map(orderId)) { StatusCode = (int)HttpStatusCode.Created};
    }

    public override async Task<IActionResult> GetOrderStatus(string orderId)
    { 
        OrderStatus orderStatus = await _orderService.GetStatus(orderId);
        return Ok(OrderStatusV1Mapper.Map(orderStatus));
    }
}