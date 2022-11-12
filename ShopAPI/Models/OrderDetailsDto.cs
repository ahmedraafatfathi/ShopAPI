using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class OrderDetailsDto
    {
        public Guid ProductId { get; set; }
        public ProductDto Product { get; set; }

        public Guid OrderId { get; set; }
        public OrderDto Order { get; set; }

        public int Count { get; set; }
    }
}
