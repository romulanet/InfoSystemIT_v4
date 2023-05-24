using Business.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataDBContext _dbContext;

        public EmployeeRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<Employee>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Employees.ToListAsync(cancellationToken);

        public Task<Employee> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken = default) =>
            _dbContext.Employees.FirstOrDefaultAsync(employee => employee.Id == employeeId, cancellationToken);

        public Task<Employee> GetByIdIncludeTaskAsync(Guid employeeId, CancellationToken cancellationToken = default) =>
            _dbContext.Employees.Where(employee => employee.Id == employeeId)
            .Include(ts => ts.ProjectTasks)
            .FirstOrDefaultAsync();

        public void Insert(Employee employee) => _dbContext.Employees.Add(employee);

        public void Remove(Employee employee) => _dbContext.Employees.Remove(employee);
    }
}
