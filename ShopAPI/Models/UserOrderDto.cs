using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class UserOrderDto
    {
        public Guid UserId { get; set; }

        public List<OrderProductDto> Products { get; set; }

        public int NumOfDays { get; set; }

    }
}
