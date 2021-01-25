using SHA3.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Extensions
{
    public static class HashExtension
    {
        public static string GetPasswordHash(string password)
        {
            if (password is null)
                return null;

            using Sha3 sha3 = Sha3.Sha3512();

            var hash = sha3.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var b in hash)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
