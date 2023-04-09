using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContractRepository
    {
        Task<List<Contract>> GetAsync(CancellationToken cancellationToken = default);

        Task<Contract> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Contract contract);

        void Remove(Contract contract);
    }
}
