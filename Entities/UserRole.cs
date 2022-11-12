using Entities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "userRole")]
    public class UserRole : BaseEntity
    {
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
