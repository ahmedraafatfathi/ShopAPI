using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "productDiscount")]
    public class ProductDiscount : BaseEntity
    {
        [JsonProperty("productId")]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("discountValue")]
        public float DiscountValue { get; set; }

        [JsonProperty("discountQty")]
        public int DiscountQty { get; set; }

    }
}
