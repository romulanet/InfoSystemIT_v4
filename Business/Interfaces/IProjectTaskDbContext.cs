using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Interfaces
{
    public interface IProjectTaskDbContext
    {
        DbSet<ProjectTask> ProjectTasks { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
