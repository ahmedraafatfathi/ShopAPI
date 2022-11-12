using AutoMapper;
using Entities;
using Entities.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.OrderService;
using ShopAPI.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    

    [ApiController]
    [Route("api/Order")]
    [Authorize]
    [SwaggerTag("Order controller")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public OrderController(IServiceProvider serviceProvider, IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<ResponseObject<bool>> Add(UserOrderDto orderDto)
        {
            var order = _mapper.Map<UserOrder>(orderDto);
            var result = await _orderService.AddOrder(order);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpGet("{orderId}")]
        public async Task<ResponseObject<OrderDto>> Get(Guid orderId)
        {
            var result = await _orderService.GetOrder(orderId);
            return _mapper.Map<ResponseObject<OrderDto>>(result);
        }

        [HttpGet("Details/{orderId}")]
        public async Task<ResponseObject<List<OrderDetailsDto>>> GetOrderDetails(Guid orderId)
        {
            var result = await _orderService.GetOrderDetails(orderId);
            return _mapper.Map<ResponseObject<List<OrderDetailsDto>>>(result);
        }


        [HttpDelete("{orderId}")]
        public async Task<ResponseObject<bool>> Delete(Guid orderId)
        {
            var result = await _orderService.DeleteOrder(orderId);
            return _mapper.Map<ResponseObject<bool>>(result);
        }
    }
}
