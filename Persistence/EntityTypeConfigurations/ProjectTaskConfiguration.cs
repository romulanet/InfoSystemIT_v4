using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ProjectTaskConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(prtask => prtask.Id);
            builder.HasIndex(prtask => prtask.Id).IsUnique();
            builder.Property(prtask => prtask.TaskTitle).HasMaxLength(50);
            builder.Property(prtask => prtask.TaskDescription).HasMaxLength(500);
            builder.HasData
          (
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow.AddDays(-10),
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow.AddDays(-7),
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("278C74E0-BFC0-48C0-8090-EE23CF303DAE"),
                  TaskTitle = "Моделирование БД",
                  TaskDescription = "Моделирование БД для разработки по проекту Экосистем",
                  TaskFinishData = DateTime.Now.AddDays(20),
                  TaskStatus = Constants.ProjectTaskStatus.Stopped,
                  TaskTimeSpent = "12 ч",
                  ProjectId = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37"),
                  EmployeeId = new Guid("D3223D1E-7CCD-4384-AC2C-734634E7B7F3")
              },
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow.AddDays(-10),
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow.AddDays(-1),
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("2F560DAF-FD18-4320-ADDF-A160F65DA673"),
                  TaskTitle = "Проектирование ИС",
                  TaskDescription = "Проектирование ИС по проекту Экосистем",
                  TaskFinishData = DateTime.Now.AddDays(40),
                  TaskStatus = Constants.ProjectTaskStatus.Stopped,
                  TaskTimeSpent = "12 ч",
                  ProjectId = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37"),
                  EmployeeId = new Guid("D3223D1E-7CCD-4384-AC2C-734634E7B7F3")
              },
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow.AddDays(-10),
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow.AddDays(-4),
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("38C87236-80B8-471E-BAD4-24C318BA022F"),
                  TaskTitle = "Тестирование ПО",
                  TaskDescription = "Тестирование ПО по проекту Экосистем",
                  TaskFinishData = DateTime.Now.AddDays(14),
                  TaskStatus = Constants.ProjectTaskStatus.Stopped,
                  TaskTimeSpent = "9 ч",
                  ProjectId = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37"),
                  EmployeeId = new Guid("64C2F517-4C27-4E23-ADBB-70077BC80834")
              },
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow.AddDays(-10),
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow.AddDays(-2),
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("E3E3675A-F500-4F8B-8A44-35A07B540300"),
                  TaskTitle = "Разработка UI",
                  TaskDescription = "Разработка UI по проекту Энергопроект",
                  TaskFinishData = DateTime.Now.AddDays(-2),
                  TaskStatus = Constants.ProjectTaskStatus.Finished,
                  TaskTimeSpent = "3 ч",
                  ProjectId = new Guid("94B1F1AC-30EE-45F8-929A-AD77CA814000"),
                  EmployeeId = new Guid("33D85A99-BDA5-4ACA-8904-ECE3CB1084EA")
              },
               new ProjectTask
               {
                   CreatedOn = DateTime.UtcNow.AddDays(-10),
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow.AddDays(-2),
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("D2016C56-3C07-47D6-8E63-124847836A6A"),
                   TaskTitle = "Разработка ТЗ",
                   TaskDescription = "Разработка ТЗ по проекту Энергопроект",
                   TaskFinishData = DateTime.Now.AddDays(-2),
                   TaskStatus = Constants.ProjectTaskStatus.Finished,
                   TaskTimeSpent = "12 ч",
                   ProjectId = new Guid("94B1F1AC-30EE-45F8-929A-AD77CA814000"),
                   EmployeeId = new Guid("EC21EC2E-FC34-4235-9575-066F56C49F5F")
               },
               new ProjectTask
               {
                   CreatedOn = DateTime.UtcNow.AddDays(-14),
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow.AddDays(-2),
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("9980061A-F8B1-4149-BFED-84DC8D702527"),
                   TaskTitle = "Разработка ТЗ",
                   TaskDescription = "Разработка ТЗ по проекту Смарт-Решения",
                   TaskFinishData = DateTime.Now.AddDays(25),
                   TaskStatus = Constants.ProjectTaskStatus.Stopped,
                   TaskTimeSpent = "6 ч",
                   ProjectId = new Guid("97D74D89-F2DB-4CF9-B4C4-1D2D52DED14E"),
                   EmployeeId = new Guid("554644C6-BE02-42B2-84C0-CB4FAEC335BD")
               },
               new ProjectTask
               {
                   CreatedOn = DateTime.UtcNow.AddDays(-16),
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow.AddDays(-2),
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("0F886C20-33E8-4FD8-A41C-3BF705D03C47"),
                   TaskTitle = "Разработка ИС",
                   TaskDescription = "Разработка ИС по проекту Смарт-Решения",
                   TaskFinishData = DateTime.Now.AddDays(30),
                   TaskStatus = Constants.ProjectTaskStatus.InProcess,
                   TaskTimeSpent = "10 ч",
                   ProjectId = new Guid("97D74D89-F2DB-4CF9-B4C4-1D2D52DED14E"),
                   EmployeeId = new Guid("D78FBBE4-7447-4D05-833C-5EEB3950E0D5")
               },
               new ProjectTask
               {
                   CreatedOn = DateTime.UtcNow.AddDays(-10),
                   CreatedBy = Constants.UserName.System,
                   UpdatedOn = DateTime.UtcNow.AddDays(-2),
                   UpdatedBy = Constants.UserName.System,
                   Id = new Guid("12A1F7CD-DB28-4FD1-A63F-8ADF27084174"),
                   TaskTitle = "Разработка ИС",
                   TaskDescription = "Редизайн ИС по проекту Смарт-Решения",
                   TaskFinishData = DateTime.Now.AddDays(45),
                   TaskStatus = Constants.ProjectTaskStatus.Stopped,
                   TaskTimeSpent = "5 ч",
                   ProjectId = new Guid("97D74D89-F2DB-4CF9-B4C4-1D2D52DED14E"),
                   EmployeeId = new Guid("D78FBBE4-7447-4D05-833C-5EEB3950E0D5")
               }
         );
        }
    }
}
