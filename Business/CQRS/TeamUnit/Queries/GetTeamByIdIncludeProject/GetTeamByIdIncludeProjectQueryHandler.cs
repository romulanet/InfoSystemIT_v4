using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeProject
{
    internal sealed class GetTeamByIdIncludeProjectQueryHandler : IQueryHandler<GetTeamByIdIncludeProjectQuery, TeamResponse>
    {
        private readonly ITeamRepository _userRepository;

        public GetTeamByIdIncludeProjectQueryHandler(ITeamRepository teamRepository) => _userRepository = teamRepository;

        public async Task<TeamResponse> Handle(GetTeamByIdIncludeProjectQuery request, CancellationToken cancellationToken)
        {
            var team = await _userRepository.GetByIdIncludeProjectAsync(request.TaskId, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return team.Adapt<TeamResponse>();
        }
    }
}