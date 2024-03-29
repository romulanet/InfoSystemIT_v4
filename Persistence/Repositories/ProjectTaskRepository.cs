﻿using Business.Common.Constants;
using Business.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private readonly DataDBContext _dbContext;

        public ProjectTaskRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<ProjectTask>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.ProjectTasks.ToListAsync(cancellationToken);

        public Task<List<ProjectTask>> GetAsyncActive(CancellationToken cancellationToken = default) =>
            _dbContext.ProjectTasks.Where(x => x.TaskStatus == Constants.ProjectTaskStatus.Stopped
            || x.TaskStatus == Constants.ProjectTaskStatus.InProcess).ToListAsync(cancellationToken);

        public Task<ProjectTask> GetByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default) =>
            _dbContext.ProjectTasks.FirstOrDefaultAsync(projectTask => projectTask.Id == projectTaskId, cancellationToken);

        public void Insert(ProjectTask projectTask) => _dbContext.ProjectTasks.Add(projectTask);

        public void Remove(ProjectTask projectTask) => _dbContext.ProjectTasks.Remove(projectTask);
    }
}
