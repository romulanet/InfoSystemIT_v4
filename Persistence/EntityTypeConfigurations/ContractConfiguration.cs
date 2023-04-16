using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(contract => contract.Id);
            builder.HasIndex(contract => contract.Id).IsUnique();
            builder.Property(contract => contract.ContractTitle).HasMaxLength(50);
            builder.Property(contract => contract.ContractDescription).HasMaxLength(500);
            builder.HasData
           (
               new Contract
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("6442D3EA-986D-4ED0-B249-6993FA75ED83"),
                   ContractTitle = "Разработка ПО",
                   ContractDescription = "Разработка ПО для клиента",
                   ContractTotalCost = "40 млн. руб",
               },
               new Contract
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("53B08E3D-7620-4F73-87EE-0B2D2686C179"),
                   ContractTitle = "Обновление ПО",
                   ContractDescription = "Обновление ПО для клиента",
                   ContractTotalCost = "20 млн. руб",
               }
           );
        }
    }
}
