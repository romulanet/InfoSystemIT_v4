﻿using Domain.Entities;

namespace Domain.IRepositories
{
    public interface IProjectTaskRepository
    {
        Task<List<ProjectTask>> GetAsync(CancellationToken cancellationToken = default);

        Task<ProjectTask> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(ProjectTask projectTask);

        void Remove(ProjectTask projectTask);
    }
}
