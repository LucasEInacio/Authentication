using Domain.Extensions;
using System;

namespace Domain.DTOs
{
    public class UserRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
