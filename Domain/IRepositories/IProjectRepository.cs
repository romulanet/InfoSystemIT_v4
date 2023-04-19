using Domain.Entities;

namespace Domain.IRepositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAsync(CancellationToken cancellationToken = default);

        Task<Project> GetByIdAsync(Guid projectId, CancellationToken cancellationToken = default);

        Task<Project> GetByIdWithTaskAsync(Guid projectId, CancellationToken cancellationToken = default);

        void Insert(Project project);

        void Remove(Project project);
    }
}
