using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Interfaces
{
    public interface IContactDbContext
    {
        DbSet<Contract> Contracts { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
