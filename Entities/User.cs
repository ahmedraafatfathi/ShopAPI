using Entities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [JsonObject(Title = "user")]
    public class User : BaseEntity
    {

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailConfirmed")]
        public bool EmailConfirmed { get; set; } = false;

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("loginType")]
        public SocialType LoginType { get; set; } = SocialType.Email;

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [NotMapped]
        [JsonProperty("password")]
        public string Password { get; set; }

        [NotMapped]
        [JsonProperty("fullName")]
        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return fullName;
                }
                else
                {
                    return fullName + " " + LastName;
                }
            }
        }

        [NotMapped]
        [JsonProperty("authToken")]
        public string Token { get; set; }

        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }



        [JsonProperty("userRoleId")]
        [ForeignKey("UserRole")]
        public Guid UserRoleId { get; set; }
        [JsonProperty("userRole")]
        public UserRole UserRole { get; set; }

    }

}
