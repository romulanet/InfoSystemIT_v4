using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Insert(Employee employee) => _dbContext.Employees.Add(employee);

        public void Remove(Employee employee) => _dbContext.Employees.Remove(employee);
    }
}
