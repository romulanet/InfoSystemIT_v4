using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Interfaces
{
    public interface IEmployeeDbContext
    {
        DbSet<Employee> Employees { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
