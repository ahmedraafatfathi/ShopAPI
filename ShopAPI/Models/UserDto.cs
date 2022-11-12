using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class UserDto
    {
        public bool Active { get; set; } = true;
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; } = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string ImageUrl { get; set; } = null;
        public string Password { get; set; }
        public bool IsBlocked { get; set; } = false;
    }
}
