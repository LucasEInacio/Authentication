using Data.EFConfiguration;
using Domain;
using Domain.DTOs;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly AuthenticationContext Db;
        protected readonly DbSet<User> DbSet;
        public UserRepository(AuthenticationContext db)
        {
            Db = db;
            DbSet = Db.Set<User>();
        }

        public void SaveUser(User user)
        {
            DbSet.Add(user);
        }

        public User GetByLogin(UserLogin login)
        {
            var query = DbSet.AsQueryable();

            return query.Where(x => x.Login == login.Login && x.Password == login.PasswordEncrypted).FirstOrDefault();
        }

        public IEnumerable<User> Get(int? id)
        {
            if (id is null)
                return DbSet;

            return new List<User> { DbSet.Find(id) };
        }
    }
}
