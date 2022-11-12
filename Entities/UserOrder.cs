using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class UserOrder
    {
        public Guid UserId { get; set; }
        
        public List<OrderProduct> Products { get; set; }

        public int NumOfDays { get; set; }
    }

    public class OrderProduct
    {
        public Guid ProductId { get; set; }
        public int Qty { get; set; }
    }
}
