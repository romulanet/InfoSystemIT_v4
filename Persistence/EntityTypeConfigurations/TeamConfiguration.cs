using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Common.Constants;

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
               TeamTitle = "Команда по проекту EcoLine",
               TeamDescription = "Команда укомлектована аналитиком",
           },
           new Team
           {
               CreatedOn = DateTime.UtcNow,
               CreatedBy = Constants.UserName.System,
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = Constants.UserName.System,
               Id = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE"),
               TeamTitle = "Команда по проекту ТехноМания",
               TeamDescription = "Команда укомлектована дизайнером",
           }
      );
        }
    }
}
