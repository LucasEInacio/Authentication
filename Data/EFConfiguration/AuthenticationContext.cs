using Data.EFConfiguration.Mapping;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EFConfiguration
{
    public class AuthenticationContext: DbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("User");
            builder.ApplyConfiguration(new UserMap());
        }
    }
}
