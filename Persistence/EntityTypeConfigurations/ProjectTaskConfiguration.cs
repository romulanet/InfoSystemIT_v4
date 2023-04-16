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
                  CreatedOn = DateTime.UtcNow,
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow,
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("278C74E0-BFC0-48C0-8090-EE23CF303DAE"),
                  TaskTitle = "Моделирование БД",
                  TaskDescription = "Моделирование БД для разработки по проекту ECOLine",
                  TaskFinishData = DateTime.Now.AddDays(20),
                  TaskStatus = Constants.ProjectStatus.InProcess,
                  TaskTimeSpent = "12 ч"
              },
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow,
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow,
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("38C87236-80B8-471E-BAD4-24C318BA022F"),
                  TaskTitle = "Тестирование ПО",
                  TaskDescription = "Тестирование ПО по проекту ECOLine",
                  TaskFinishData = DateTime.Now.AddDays(14),
                  TaskStatus = Constants.ProjectStatus.InProcess,
                  TaskTimeSpent = "2 ч"
              }
         );
        }
    }
}
