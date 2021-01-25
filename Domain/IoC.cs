using Domain.Services;
using System;
using System.Collections.Generic;

namespace Domain
{
    public static class IoC
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(IUserService), typeof(UserService) },
                { typeof(ITokenService), typeof(TokenService) }
            };
        }
    }
}