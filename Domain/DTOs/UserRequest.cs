using System;

namespace Domain.DTOs
{
    public class UserRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
