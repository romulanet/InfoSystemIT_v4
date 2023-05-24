using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeProjectEmployee
{
    internal sealed class GetTeamByIdIncludeAllQueryHandler : IQueryHandler<GetTeamByIdIncludeAllQuery, TeamResponse>
    {
        private readonly ITeamRepository _userRepository;

        public GetTeamByIdIncludeAllQueryHandler(ITeamRepository teamRepository) => _userRepository = teamRepository;

        public async Task<TeamResponse> Handle(GetTeamByIdIncludeAllQuery request, CancellationToken cancellationToken)
        {
            var team = await _userRepository.GetByIdIncludeAllAsync(request.TaskId, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return team.Adapt<TeamResponse>();
        }
    }
}