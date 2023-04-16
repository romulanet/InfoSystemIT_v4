using Domain.Entities;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataDBContext _dbContext;

        public ProjectRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<Project>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Projects.ToListAsync(cancellationToken);

        public Task<Project> GetByIdAsync(Guid projectId, CancellationToken cancellationToken = default) =>
            _dbContext.Projects.FirstOrDefaultAsync(project => project.Id == projectId, cancellationToken);

        public void Insert(Project project) => _dbContext.Projects.Add(project);

        public void Remove(Project project) => _dbContext.Projects.Remove(project);
    }
}
