using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly DataDBContext _dbContext;

        public TeamRepository(DataDBContext dbContext) => _dbContext = dbContext;

        public Task<List<Team>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Teams.ToListAsync(cancellationToken);

        public Task<Team> GetByIdAsync(Guid teamId, CancellationToken cancellationToken = default) =>
            _dbContext.Teams.FirstOrDefaultAsync(team => team.Id == teamId, cancellationToken);

        public void Insert(Team team) => _dbContext.Teams.Add(team);

        public void Remove(Team team) => _dbContext.Teams.Remove(team);
    }
}
