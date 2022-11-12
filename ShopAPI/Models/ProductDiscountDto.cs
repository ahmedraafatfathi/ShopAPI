using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class ProductDiscountDto
    {
        public Guid ProductId { get; set; }
        public float DiscountValue { get; set; }
        public int DiscountQty { get; set; }
    }
}
