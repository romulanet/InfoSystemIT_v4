using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAsync(CancellationToken cancellationToken = default);

        Task<Team> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Team team);

        void Remove(Team team);
    }
}
