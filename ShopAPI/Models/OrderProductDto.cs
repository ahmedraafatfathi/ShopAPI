using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class OrderProductDto
    {
        public Guid ProductId { get; set; }
        public int Qty { get; set; }
    }
}
