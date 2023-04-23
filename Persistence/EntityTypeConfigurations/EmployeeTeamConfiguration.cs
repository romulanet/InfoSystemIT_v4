using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityTypeConfigurations
{
    public class EmployeeTeamConfiguration : IEntityTypeConfiguration<Employee_Team>
    {
        public void Configure(EntityTypeBuilder<Employee_Team> builder)
        {
            builder.HasKey(t => new { t.EmployeeId, t.TeamId });
            //builder.Property(x => x.EmployeeId).ValueGeneratedOnAdd();
            //builder.Property(x => x.TeamId).ValueGeneratedOnAdd();
            builder.HasOne(sc => sc.Employee)
                .WithMany(s => s.Employees_Teams)
                .HasForeignKey(sc => sc.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(sc => sc.Team)
                .WithMany(c => c.Employees_Teams)
                .HasForeignKey(sc => sc.TeamId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasData
                (
                    new Employee_Team
                    {
                        EmployeeId = new Guid("64C2F517-4C27-4E23-ADBB-70077BC80834"),
                        TeamId = new Guid("9E1257C8-00D1-4BA9-80AF-F84B8E29431A")
                    },
                    new Employee_Team
                    {
                        EmployeeId = new Guid("64C2F517-4C27-4E23-ADBB-70077BC80834"),
                        TeamId = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE")
                    },
                    new Employee_Team
                    {
                        EmployeeId = new Guid("EC21EC2E-FC34-4235-9575-066F56C49F5F"),
                        TeamId = new Guid("1C29869D-49E6-4A8E-A1EB-8773497E80FE")
                    }
                );
        }
    }
}
