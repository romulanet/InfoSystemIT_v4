using Business.Common.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(team => team.Id);
            builder.HasIndex(team => team.Id).IsUnique();
            builder.Property(team => team.TeamTitle).HasMaxLength(50);
            builder.Property(team => team.TeamDescription).HasMaxLength(500);
            builder.HasData
       (
           new Team
           {
               CreatedOn = DateTime.UtcNow,
               CreatedBy = Constants.UserName.System,
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = Constants.UserName.System,
               Id = new Guid("9E1257C8-00D1-4BA9-80AF-F84B8E29431A"),
               TeamTitle = "Команда по проекту Экосистем",
               TeamDescription = "Команда укомлектована аналитиком",

           },
           new Team
           {
               CreatedOn = DateTime.UtcNow,
               CreatedBy = Constants.UserName.System,
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = Constants.UserName.System,
               Id = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE"),
               TeamTitle = "Команда по проекту Энергопроект",
               TeamDescription = "Команда укомлектована дизайнером",
           },
           new Team
           {
               CreatedOn = DateTime.UtcNow,
               CreatedBy = Constants.UserName.System,
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = Constants.UserName.System,
               Id = new Guid("F97FAB25-21DE-44CB-B6C2-5F1DB493D614"),
               TeamTitle = "Команда по проекту Смарт-Решения",
               TeamDescription = "Команда укомлектована аналитиком",
           }
      );
        }
    }
}
