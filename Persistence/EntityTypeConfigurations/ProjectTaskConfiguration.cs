using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

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
        }
    }
}
