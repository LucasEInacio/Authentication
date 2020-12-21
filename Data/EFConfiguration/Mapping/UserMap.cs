using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EFConfiguration.Mapping
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.Id).HasColumnName("Id");

            builder.Property(a => a.Login)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(a => a.Password)
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(a => a.CreationDate)
                .HasColumnType("Datetime")
                .IsRequired();
        }
    }
}