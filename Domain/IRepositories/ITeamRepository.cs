using Domain.Entities;

namespace Domain.IRepositories
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAsync(CancellationToken cancellationToken = default);

        Task<Team> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Team> GetByIdIncludeProjectAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Team team);

        void Remove(Team team);
    }
}
