using Entities;
using Entities.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.OrderService
{
    public interface IOrderService
    {
        Task<ResponseObject<bool>> AddOrder(UserOrder Order);
        Task<ResponseObject<bool>> DeleteOrder(Guid OrderId);
        Task<ResponseObject<Order>> GetOrder(Guid OrderId);
        Task<ResponseObject<List<OrderDetails>>> GetOrderDetails(Guid orderId);
    }
}
