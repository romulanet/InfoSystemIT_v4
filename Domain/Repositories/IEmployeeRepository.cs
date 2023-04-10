using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public  interface IEmployeeRepository
    {
        Task<List<Employee>> GetAsync(CancellationToken cancellationToken = default);

        Task<Employee> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Employee employee);

        void Remove(Employee employee);
    }
}
