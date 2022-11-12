using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "orderDetails")]
    public class OrderDetails : BaseEntity
    {
        [JsonProperty("productId")]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [JsonProperty("product")]
        public Product Product { get; set; }


        [JsonProperty("orderId")]
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        [JsonProperty("order")]
        public Order Order { get; set; }

        public int Count { get; set; }
    }
}
