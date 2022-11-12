using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "category")]
    public class Category : BaseEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
