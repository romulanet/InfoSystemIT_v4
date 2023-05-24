using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistence.EntityTypeConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.Id);
            builder.HasIndex(customer => customer.Id).IsUnique();
            builder.Property(customer => customer.CustomerCompanyTitle).HasMaxLength(50);
            builder.Property(customer => customer.CustomerCountry).HasMaxLength(25);
            builder.HasData
            (
                new Customer
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    UpdatedOn = DateTime.UtcNow,
                    UpdatedBy = Constants.UserName.System,
                    Id = new Guid("7DF41162-1895-48D4-90ED-321E4291789E"),
                    CustomerFName = "Дмитрий",
                    CustomerMName = "Витальевич",
                    CustomerLName = "Загородский",
                    CustomerCompanyTitle = "Экосистемы",
                    CustomerCountry = "Россия",
                    CustomerTelNumber = "89035678945",
                    CustomerMailAddress = "EcoSystem@eco.ru",
                    CustomerPostAddress = "г. Москва пр. Ленина 21 офис 14"

                },
                new Customer
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    UpdatedOn = DateTime.UtcNow,
                    UpdatedBy = Constants.UserName.System,
                    Id = new Guid("A8FD7901-4A88-4199-A08C-2BA723D094EA"),
                    CustomerFName = "Петр",
                    CustomerMName = "Петрович",
                    CustomerLName = "Васнецов",
                    CustomerCompanyTitle = "Энергопроект",
                    CustomerCountry = "Россия",
                    CustomerTelNumber = "8910567890",
                    CustomerMailAddress = "energoProject@ep.ru",
                    CustomerPostAddress = "г. Воронеж ул. Воронина 56 офис 21"
                },
                new Customer
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    UpdatedOn = DateTime.UtcNow,
                    UpdatedBy = Constants.UserName.System,
                    Id = new Guid("7FA2A4B2-C04C-4F2E-8E32-218A60914684"),
                    CustomerFName = "Василий",
                    CustomerMName = "Иванович",
                    CustomerLName = "Колыванов",
                    CustomerCompanyTitle = "Смарт-Решения",
                    CustomerCountry = "Россия",
                    CustomerTelNumber = "8916766891",
                    CustomerMailAddress = "smartD@sd.ru",
                    CustomerPostAddress = "г.Калуга ул. Ковалёва 15 офис 56"
                }
            );
        }
    }
}
