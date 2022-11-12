using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "userPassword")]
    public class UserPassword : BaseEntity
    {

        [JsonProperty("userId")]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("hashPassword")]
        public string HashPassword { get; set; }

        [JsonProperty("isCurrent")]
        public bool IsCurrent { get; set; }

    }

}
