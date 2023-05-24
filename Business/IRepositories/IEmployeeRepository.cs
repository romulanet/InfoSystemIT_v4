using Domain.Entities;

namespace Business.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAsync(CancellationToken cancellationToken = default);

        Task<Employee> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        Task<Employee> GetByIdIncludeTaskAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Employee employee);

        void Remove(Employee employee);
    }
}
