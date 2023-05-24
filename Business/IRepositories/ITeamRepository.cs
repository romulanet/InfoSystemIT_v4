using Domain.Entities;

namespace Business.IRepositories
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAsync(CancellationToken cancellationToken = default);

        Task<Team> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Team> GetByIdIncludeAllAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Team> GetByIdIncludeEmployeeAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Team team);

        void Remove(Team team);
    }
}
