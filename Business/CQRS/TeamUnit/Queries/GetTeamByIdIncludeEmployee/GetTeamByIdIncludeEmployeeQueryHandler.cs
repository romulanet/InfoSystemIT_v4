using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeEmployee
{
    internal sealed class GetTeamByIdIncludeEmployeeQueryHandler : IQueryHandler<GetTeamByIdIncludeEmployeeQuery, TeamResponse>
    {
        private readonly ITeamRepository _userRepository;

        public GetTeamByIdIncludeEmployeeQueryHandler(ITeamRepository teamRepository) => _userRepository = teamRepository;

        public async Task<TeamResponse> Handle(GetTeamByIdIncludeEmployeeQuery request, CancellationToken cancellationToken)
        {
            var team = await _userRepository.GetByIdIncludeEmployeeAsync(request.TaskId, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return team.Adapt<TeamResponse>();
        }
    }
}