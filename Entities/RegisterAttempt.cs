using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class RegisterAttempt : BaseEntity
    {
        [JsonProperty("userId")]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }


        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("isUsed")]
        public bool IsUsed { get; set; }

    }

}
