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
                   TeamId = new Guid("9E1257C8-00D1-4BA9-80AF-F84B8E29431A")                            
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
                    EmployeeJobTitle = "Аналитик",
                    EmployeeTelNumber = "89076222241",
                    EmployeeMailAddress = "korenkov@prog.ru",
                    EmployeePostAddress = "г.Уфа ул. Ленина 14 ",
                    TeamId = new Guid("9E1257C8-00D1-4BA9-80AF-F84B8E29431A")

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
                   EmployeePostAddress = "г.Мытищи ул. Вологда 33",
                   TeamId = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE")
               },
               new Employee
               {
                   CreatedOn = DateTime.UtcNow,
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow,
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("33D85A99-BDA5-4ACA-8904-ECE3CB1084EA"),
                   EmployeeFName = "Пётр",
                   EmployeeMName = "Андреевич",
                   EmployeeLName = "Гордеев",
                   EmployeeJobTitle = "Дизайнер",
                   EmployeeTelNumber = "8970545821",
                   EmployeeMailAddress = "parinkov@prog.ru",
                   EmployeePostAddress = "г.Мытищи ул. Вологда 33",
                   TeamId = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE")
               }
           );
        }
    }
}
