using Business.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

        public Task<Team> GetByIdIncludeAllAsync(Guid teamId, CancellationToken cancellationToken = default) =>
             _dbContext.Teams.Where(team => team.Id == teamId)
            .Include(ts => ts.Projects)
            .Include(ts => ts.Employees)
            .FirstOrDefaultAsync();
        public Task<Team> GetByIdIncludeEmployeeAsync(Guid teamId, CancellationToken cancellationToken = default) =>
          _dbContext.Teams.Where(team => team.Id == teamId)
         .Include(ts => ts.Employees)
         .FirstOrDefaultAsync();


        public void Insert(Team team) => _dbContext.Teams.Add(team);

        public void Remove(Team team) => _dbContext.Teams.Remove(team);
    }
}
