using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "product")]
    public class Product : BaseEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("availableQty")]
        public int AvailableQty { get; set; }

        [JsonProperty("categoryId")]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }

    }
}
