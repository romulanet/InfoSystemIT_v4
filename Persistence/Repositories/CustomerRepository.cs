using Business.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly DataDBContext _dbContext;

        public CustomerRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<Customer>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Customers.ToListAsync(cancellationToken);

        public Task<Customer> GetByIdAsync(Guid customerId, CancellationToken cancellationToken = default) =>
            _dbContext.Customers.FirstOrDefaultAsync(customer => customer.Id == customerId, cancellationToken);

        public Task<Customer> GetByIdWithContractAsync(Guid customerId, CancellationToken cancellationToken = default) =>
            _dbContext.Customers.Where(customer => customer.Id == customerId)
            .Include(ts => ts.Contracts)
            .FirstOrDefaultAsync();

        public void Insert(Customer customer) => _dbContext.Customers.Add(customer);

        public void Remove(Customer customer) => _dbContext.Customers.Remove(customer);
    }
}
