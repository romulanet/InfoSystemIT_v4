using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Interfaces
{
    public interface ITeamDbContext
    {
        DbSet<Team> Teams { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
