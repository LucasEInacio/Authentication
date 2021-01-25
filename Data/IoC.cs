using Data.Repositories;
using Data.UoW;
using Domain;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace Data
{
    public static class IoC
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(IUserRepository), typeof(UserRepository) },
                { typeof(IUnitOfWork), typeof(UnitOfWork) }
            };
        }
    }
}
