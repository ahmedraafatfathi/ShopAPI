using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "order")]
    public class Order : BaseEntity
    {
        [JsonProperty("submittedDate")]
        public DateTime? SubmittedDate { get; set; }

        [JsonProperty("isSubmitted")]
        public bool IsSubmitted { get; set; }

        [JsonProperty("maxDeliveryDays")]
        public int MaxDeliveryDays { get; set; }

        [JsonProperty("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty("totalPrice")]
        public float TotalPrice { get; set; } = 0;

        [JsonProperty("totalDiscount")]
        public float TotalDiscount { get; set; } = 0;

        [JsonProperty("userId")]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
