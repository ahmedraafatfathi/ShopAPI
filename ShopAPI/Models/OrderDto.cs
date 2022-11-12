using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class OrderDto
    {
        public DateTime? SubmittedDate { get; set; }
        public bool IsSubmitted { get; set; }
        public int MaxDeliveryDays { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public Guid UserId { get; set; }
    }
}
