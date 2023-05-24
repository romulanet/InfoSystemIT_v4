using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.IRepositories;
using Business.Responses;
using Domain.Entities;
using Mapster;

namespace Business.CQRS.TeamUnit.Commands.CreateTeam
{
    internal sealed class CreateTeamCommandHandler : ICommandHandler<CreateTeamCommand, TeamResponse>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateTeamCommandHandler(ITeamRepository teamRepository, IUnitOfWork unitOfWork)
        {
            _teamRepository = teamRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TeamResponse> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = new Team(
                request.TeamTitle,
                request.TeamDescription
                );
            team.CreatedOn = DateTime.Now;
            team.CreatedBy = Constants.UserName.System;

            _teamRepository.Insert(team);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return team.Adapt<TeamResponse>();
        }
    }
}