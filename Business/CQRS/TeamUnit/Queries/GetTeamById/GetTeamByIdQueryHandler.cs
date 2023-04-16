using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeamById
{
    internal sealed class GetTeamByIdQueryHandler : IQueryHandler<GetTeamByIdQuery, TeamResponse>
    {
        private readonly ITeamRepository _userRepository;

        public GetTeamByIdQueryHandler(ITeamRepository teamRepository) => _userRepository = teamRepository;

        public async Task<TeamResponse> Handle(GetTeamByIdQuery request, CancellationToken cancellationToken)
        {
            var team = await _userRepository.GetByIdAsync(request.TaskId, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return team.Adapt<TeamResponse>();
        }
    }
}