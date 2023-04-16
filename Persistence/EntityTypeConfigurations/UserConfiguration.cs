﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.EntityTypeConfigurations
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
           (
               new User
               {
                   Id = "f3bd501d-6647-4f51-95ce-412ae3552ed9",
                   FirstName = "admin",
                   UserName = "admin",
                   NormalizedUserName = "ADMIN",
                   Email = "admin@admin",
                   NormalizedEmail = "ADMIN@ADMIN",
                   PasswordHash = "AQAAAAEAACcQAAAAEKEDcwyDbzgtKJayFDqQtjqdc30H1/pBn4BLjKi4P7GA7MNO0TyymjLTrruZdjEzDA==",
                   SecurityStamp = "WCBIVXTPLTZ57TRN53RAKPY6EM6V62CL",
                   ConcurrencyStamp = "340aa380-03c4-45ab-a8e9-196e2d29f984"
               }
           );
        }
    }
}

