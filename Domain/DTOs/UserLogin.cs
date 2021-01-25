using Domain.Extensions;
using System;

namespace Domain.DTOs
{
    public class UserLogin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordEncrypted => string.IsNullOrEmpty(Password) ? string.Empty : HashExtension.GetPasswordHash(Password);
        public string AccessType { get; set; }
        public string Token { get; set; }

        public void InsertToken(string token)
        {
            Password = string.Empty;
            Token = token;
        }
    }
}
