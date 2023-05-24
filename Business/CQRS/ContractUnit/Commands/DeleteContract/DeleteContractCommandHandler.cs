using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using MediatR;

namespace Business.CQRS.ContractUnit.Commands.DeleteContract
{
    internal sealed class DeleteProjectCommandHandler : ICommandHandler<DeleteProjectCommand, Unit>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProjectCommandHandler(IContractRepository contractRepository, IUnitOfWork unitOfWork)
        {
            _contractRepository = contractRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.GetByIdAsync(request.ContractId, cancellationToken);

            if (contract is null)
            {
                throw new EntityNotFoundException(request.ContractId);
            }

            _contractRepository.Remove(contract);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
