using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
