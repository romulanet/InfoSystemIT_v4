using Domain.Entities;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private readonly DataDBContext _dbContext;

        public ProjectTaskRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<ProjectTask>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.ProjectTasks.ToListAsync(cancellationToken);

        public Task<ProjectTask> GetByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default) =>
            _dbContext.ProjectTasks.FirstOrDefaultAsync(projectTask => projectTask.Id == projectTaskId, cancellationToken);

        public void Insert(ProjectTask projectTask) => _dbContext.ProjectTasks.Add(projectTask);

        public void Remove(ProjectTask projectTask) => _dbContext.ProjectTasks.Remove(projectTask);
    }
}
