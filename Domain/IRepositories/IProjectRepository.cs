using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAsync(CancellationToken cancellationToken = default);

        Task<Project> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Project project);

        void Remove(Project project);
    }
}
