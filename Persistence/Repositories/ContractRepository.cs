using Domain.Entities;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public sealed class ContractRepository : IContractRepository
    {
        private readonly DataDBContext _dbContext;

        public ContractRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<Contract>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Contracts.ToListAsync(cancellationToken);

        public Task<Contract> GetByIdAsync(Guid contractId, CancellationToken cancellationToken = default) =>
            _dbContext.Contracts.FirstOrDefaultAsync(contract => contract.Id == contractId, cancellationToken);

        public void Insert(Contract contract) => _dbContext.Contracts.Add(contract);

        public void Remove(Contract contract) => _dbContext.Contracts.Remove(contract);
    }
}
