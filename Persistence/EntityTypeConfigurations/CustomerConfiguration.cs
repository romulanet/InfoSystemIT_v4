﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using Business.Common.Constants;

namespace Persistence.EntityTypeConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(note => note.Id);
            builder.HasIndex(note => note.Id).IsUnique();
            builder.Property(note => note.CustomerCompanyTitle).HasMaxLength(50);
            builder.Property(note => note.CustomerCountry).HasMaxLength(25);
            builder.HasData
            (
                new Customer
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    CustomerFName = "Дмитрий",
                    CustomerLName = "Загородский"

                },
                new Customer
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    CustomerFName = "Петр",
                    CustomerLName = "Вологодский"

                }
            );
        }
    }
}