using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public interface IUserRepository
    {
        void SaveUser(User user);
        User GetByLogin(UserLogin login);
        IEnumerable<User> Get(int? id);
    }
}
