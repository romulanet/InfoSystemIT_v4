using Business.Exceptions;
using MediatR;
using Business.Common.Constants;
using Domain.IRepositories;
using Business.Abstractions.Messages;
using static Business.Common.Constants.Constants;

namespace Business.CQRS.TeamUnit.Commands.UpdateTeam
{
    internal sealed class UpdateTeamCommandHandler : ICommandHandler<UpdateTeamCommand, Unit>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateTeamCommandHandler(ITeamRepository teamRepository, IUnitOfWork unitOfWork)
        {
            _teamRepository = teamRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetByIdAsync(request.Id, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            team.UpdatedBy = Constants.UserName.System;
            team.UpdatedOn = DateTime.Now;
            team.Update(
                request.TeamTitle,
                request.TeamDescription
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
