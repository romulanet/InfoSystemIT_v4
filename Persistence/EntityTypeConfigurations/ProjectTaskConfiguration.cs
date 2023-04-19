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
                  TaskStatus = Constants.ProjectTaskStatus.Stopped,
                  TaskTimeSpent = "12 ч",
                  ProjectId = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37")
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
                  TaskStatus = Constants.ProjectTaskStatus.Stopped,
                  TaskTimeSpent = "2 ч",
                  ProjectId = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37")
              },
              new ProjectTask
              {
                  CreatedOn = DateTime.UtcNow.AddDays(-10),
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow.AddDays(-2),
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("E3E3675A-F500-4F8B-8A44-35A07B540300"),
                  TaskTitle = "Разработка UI",
                  TaskDescription = "Разработка UI по проекту ТехноМания",
                  TaskFinishData = DateTime.Now.AddDays(-2),
                  TaskStatus = Constants.ProjectTaskStatus.Finished,
                  TaskTimeSpent = "2 ч",
                  ProjectId = new Guid("94B1F1AC-30EE-45F8-929A-AD77CA814000")
              }
         );
        }
    }
}
