using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Interfaces
{
    public interface ICustomerDbContext
    {
        DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
