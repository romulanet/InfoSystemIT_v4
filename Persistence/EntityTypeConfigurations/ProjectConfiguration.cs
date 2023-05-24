using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(project => project.Id);
            builder.HasIndex(project => project.Id).IsUnique();
            builder.Property(project => project.ProjectTitle).HasMaxLength(50);
            builder.Property(project => project.ProjectDescription).HasMaxLength(500);
            builder.HasData
          (
              new Project
              {
                  CreatedOn = DateTime.UtcNow,
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow,
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("1E9C86B9-5976-4713-8C01-1601B74E9D37"),
                  ProjectTitle = "Разработка ИС для Экосистем",
                  ProjectType = "Разработка ИС",
                  ProjectDescription = "Разработка ИС, Разработка и развёртывание",
                  ProjectStatus = Constants.ProjectStatus.InProcess,
                  ProjectTimeSpent = "300 ч",
                  ProjectFinishData = DateTime.Today.AddDays(120),
                  ContractId = new Guid("6442D3EA-986D-4ED0-B249-6993FA75ED83"),
                  TeamId = new Guid("9E1257C8-00D1-4BA9-80AF-F84B8E29431A")

              },
              new Project
              {
                  CreatedOn = DateTime.UtcNow,
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow,
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("94B1F1AC-30EE-45F8-929A-AD77CA814000"),
                  ProjectTitle = "Обновление ИС Энергопроект",
                  ProjectType = "Обновление ИС",
                  ProjectDescription = "Обновление ИС, Обновление и тестирование",
                  ProjectStatus = Constants.ProjectStatus.InProcess,
                  ProjectTimeSpent = "150 ч",
                  ProjectFinishData = DateTime.Today.AddDays(100),
                  ContractId = new Guid("53B08E3D-7620-4F73-87EE-0B2D2686C179"),
                  TeamId = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE")
              },
              new Project
              {
                  CreatedOn = DateTime.UtcNow,
                  CreatedBy = Constants.UserName.System,
                  UpdatedOn = DateTime.UtcNow,
                  UpdatedBy = Constants.UserName.System,
                  Id = new Guid("97D74D89-F2DB-4CF9-B4C4-1D2D52DED14E"),
                  ProjectTitle = "Реинжениринг ИС Смарт-Решения",
                  ProjectType = "Реинжениринг ИС",
                  ProjectDescription = "Реинжениринг ИС, Реинжениринг и развёртывание",
                  ProjectStatus = Constants.ProjectStatus.InProcess,
                  ProjectTimeSpent = "400 ч",
                  ProjectFinishData = DateTime.Today.AddDays(160),
                  ContractId = new Guid("3E53A63A-CD4C-49FD-816D-D8D5D136DCE4"),
                  TeamId = new Guid("F97FAB25-21DE-44CB-B6C2-5F1DB493D614")
              }
          );
        }
    }
}
