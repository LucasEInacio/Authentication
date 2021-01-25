using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public interface IUserService
    {
        bool SaveUser(UserRequest user);
        UserLogin Login(UserLogin request);
        IEnumerable<User> GetUsers(int? id);
    }
}
