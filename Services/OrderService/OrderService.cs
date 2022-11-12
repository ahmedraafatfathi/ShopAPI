using Entities;
using Entities.Response;
using Repository;
using Services.ProductService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order> _repository;
        private readonly IBaseRepository<OrderDetails> _repositoryDetails;
        private readonly IBaseRepository<ProductDiscount> _repositoryProductDiscount;
        private readonly IProductService _productService;


        public OrderService(IBaseRepository<Order> repository,
            IBaseRepository<OrderDetails> repositoryDetails,
            IBaseRepository<ProductDiscount> repositoryProductDiscount,
            IProductService productService)
        {
            _repository = repository;
            _repositoryDetails = repositoryDetails;
            _repositoryProductDiscount = repositoryProductDiscount;
            _productService = productService;
        }


        public async Task<ResponseObject<bool>> AddOrder(UserOrder order)
        {
            try
            {
                var orderInfo = new Order();
                orderInfo.UserId = order.UserId;
                orderInfo.MaxDeliveryDays = order.NumOfDays;
                orderInfo.SubmittedDate = DateTime.Now;
                orderInfo.IsSubmitted = true;
                
                var done = await _repository.Insert(orderInfo);
                if (done)
                {
                    foreach (var item in order.Products)
                    {
                        var product = await _productService.GetProduct(item.ProductId);
                        var discountInfo = await _repositoryProductDiscount.GetFirstWhereOrdered(a => a.ProductId == item.ProductId && a.DiscountQty == item.Qty , a=>a.DiscountValue);
                        

                        OrderDetails details = new OrderDetails();
                        details.ProductId = item.ProductId;
                        details.Count = item.Qty;
                        details.OrderId = orderInfo.Id;
                        
                        if(discountInfo != null)
                        {
                            var discountVal = discountInfo.DiscountValue / 100 * product.Data.Price;
                            orderInfo.TotalPrice += product.Data.Price - discountVal;
                            orderInfo.TotalDiscount += discountVal;
                        }
                        else
                        {
                            orderInfo.TotalPrice += product.Data.Price;
                        }

                        await _repositoryDetails.Insert(details);
                    }

                    _repository.Update(orderInfo);
                    return new ResponseObject<bool>(true, message: "Order added sussefully");
                }

                return new ResponseObject<bool>(false, message: "Failed to add this order");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }

        }
        public async Task<ResponseObject<bool>> DeleteOrder(Guid OrderId)
        {

            try
            {
                var order = await _repository.GetById(OrderId);
                if (order != null)
                {
                    bool deleted = _repository.Delete(order);
                    if (deleted)
                    {
                        var orderDetails = await _repositoryDetails.Where(a => a.OrderId == OrderId);
                        foreach (var item in orderDetails)
                        {
                            _repositoryDetails.Delete(item);
                        }
                    }
                    return new ResponseObject<bool>(true, message: "Category successfully deleted");
                }
                return new ResponseObject<bool>(false, message: "Category not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<Order>> GetOrder(Guid OrderId)
        {

            try
            {
                var order = await _repository.GetById(OrderId);
                if (order != null)
                    return new ResponseObject<Order>(order, message: "Order successfully deleted");

                return new ResponseObject<Order>(null, message: "Order not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<Order>(ex);
            }
        }
        public async Task<ResponseObject<List<OrderDetails>>> GetOrderDetails(Guid orderId)
        {
            try
            {
                string[] includes = { "Order", "Product" };
                var orders = await _repositoryDetails.Where(a => a.OrderId == orderId, includes);
                if (orders != null && orders.Count > 0)
                    return new ResponseObject<List<OrderDetails>>(orders, message: "Orders successfully deleted");

                return new ResponseObject<List<OrderDetails>>(null, message: "Failed to get orders");
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<OrderDetails>>(ex);
            }
        }
    }
}
