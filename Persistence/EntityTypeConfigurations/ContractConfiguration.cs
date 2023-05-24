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
                   ContractTitle = "Разработка ИС для Экосистем",
                   ContractDescription = "Разработка ПО.Дмитрий Загородский",
                   ContractTotalCost = "40 млн. руб",
                   CustomerId = new Guid("7DF41162-1895-48D4-90ED-321E4291789E")
               },
               new Contract
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("53B08E3D-7620-4F73-87EE-0B2D2686C179"),
                   ContractTitle = "Обновление ИС Энергопроект",
                   ContractDescription = "Обновление ИС Петр Васнецов",
                   ContractTotalCost = "20 млн. руб",
                   CustomerId = new Guid("A8FD7901-4A88-4199-A08C-2BA723D094EA")
               },
               new Contract
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("3E53A63A-CD4C-49FD-816D-D8D5D136DCE4"),
                   ContractTitle = "Реинжениринг ИС Смарт-Решения",
                   ContractDescription = "Реинжениринг ИС. Василий Колыванов",
                   ContractTotalCost = "20 млн. руб",
                   CustomerId = new Guid("7FA2A4B2-C04C-4F2E-8E32-218A60914684")
               }
           );
        }
    }
}
