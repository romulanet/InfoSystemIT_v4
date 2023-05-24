using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
               },
               new User
               {
                   Id = "f3bd501d-6647-4f51-95ce-412ae3552ee9",
                   FirstName = "Ravil",
                   UserName = "Ravil",
                   NormalizedUserName = "RAVIL",
                   Email = "ravil@mail.com",
                   NormalizedEmail = "RAVIL@MAIL.COM",
                   PasswordHash = "AQAAAAEAACcQAAAAEMQrxMoeM/bI2Dtkpe/zkgr2QAQwRx1HZIkpBuqXBbgtsRfvB9dSgxBnATU0gSZQeg==",
                   SecurityStamp = "HR2DKDZZFCG555WQRJVEUZ4CMPVQPDSX",
                   ConcurrencyStamp = "c9a74009-ca76-4231-bad5-39b8f7663830"
               }
           );
        }
    }
}

