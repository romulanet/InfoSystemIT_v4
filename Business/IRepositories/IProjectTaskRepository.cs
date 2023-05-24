using Domain.Entities;

namespace Business.IRepositories
{
    public interface IProjectTaskRepository
    {
        Task<List<ProjectTask>> GetAsync(CancellationToken cancellationToken = default);

        Task<List<ProjectTask>> GetAsyncActive(CancellationToken cancellationToken = default);

        Task<ProjectTask> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(ProjectTask projectTask);

        void Remove(ProjectTask projectTask);
    }
}
