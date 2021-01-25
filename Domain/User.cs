using Domain.Extensions;
using System;

namespace Domain
{
    public class User
    {
        public User(string login, string password, DateTime creationDate, string role)
        {
            Login = login;
            Password = HashExtension.GetPasswordHash(password);
            CreationDate = creationDate;
            Role = role;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
