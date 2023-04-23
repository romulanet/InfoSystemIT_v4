using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.Id);
            builder.HasIndex(employee => employee.Id).IsUnique();
            builder.Property(employee => employee.EmployeeJobTitle).HasMaxLength(50);
            builder.HasData
           (
               new Employee
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("64C2F517-4C27-4E23-ADBB-70077BC80834"),
                   EmployeeFName = "Дмитрий",
                   EmployeeMName = "Васильевич",
                   EmployeeLName = "Коренков",
                   EmployeeJobTitle = "Програмист",
                   EmployeeTelNumber = "89056673245",
                   EmployeeMailAddress = "korenkov@prog.ru",
                   EmployeePostAddress = "г.Москва пр. Маркса 21 ",
                   
                  
               },
                new Employee
                {
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = Constants.UserName.System,
                    UpdatedOn = DateTime.UtcNow,
                    UpdatedBy = Constants.UserName.System,
                    Id = new Guid("D3223D1E-7CCD-4384-AC2C-734634E7B7F3"),
                    EmployeeFName = "Виталий",
                    EmployeeMName = "Витальевич",
                    EmployeeLName = "Валежник",
                    EmployeeJobTitle = "Дизайнер",
                    EmployeeTelNumber = "89076222241",
                    EmployeeMailAddress = "korenkov@prog.ru",
                    EmployeePostAddress = "г.Уфа ул. Ленина 14 "

                },
               new Employee
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("EC21EC2E-FC34-4235-9575-066F56C49F5F"),
                   EmployeeFName = "Андрей",
                   EmployeeMName = "Витальевич",
                   EmployeeLName = "Паринков",
                   EmployeeJobTitle = "Менеджер проекта",
                   EmployeeTelNumber = "8970545821",
                   EmployeeMailAddress = "parinkov@prog.ru",
                   EmployeePostAddress = "г.Мытищи ул. Вологда 33"
               }
           );
        }
    }
}
