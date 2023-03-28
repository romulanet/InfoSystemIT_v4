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
        }
    }
}
