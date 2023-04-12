using Business.Abstractions.Messages;
using Business.Exceptions;
using Domain.IRepositories;
using MediatR;

namespace Business.CQRS.TeamUnit.Commands.DeleteTeam
{
    internal sealed class DeleteTeamCommandHandler : ICommandHandler<DeleteTeamCommand, Unit>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTeamCommandHandler(ITeamRepository teamRepository, IUnitOfWork unitOfWork)
        {
            _teamRepository = teamRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteTeamCommand request, CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetByIdAsync(request.TeamId, cancellationToken);

            if (team is null)
            {
                throw new EntityNotFoundException(request.TeamId);
            }

            _teamRepository.Remove(team);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
