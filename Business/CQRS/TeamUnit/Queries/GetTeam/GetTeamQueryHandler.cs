using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeam
{
    internal sealed class GetTeamQueryHandler : IQueryHandler<GetTeamQuery, List<TeamResponse>>
    {
        private readonly ITeamRepository _teamRepository;

        public GetTeamQueryHandler(ITeamRepository userRepository) => _teamRepository = userRepository;

        public async Task<List<TeamResponse>> Handle(GetTeamQuery request, CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetAsync(cancellationToken);

            return team.Adapt<List<TeamResponse>>();
        }
    }
}