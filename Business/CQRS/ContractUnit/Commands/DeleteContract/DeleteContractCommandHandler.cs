using Business.Abstractions.Messages;
using Business.Exceptions;
using Domain.IRepositories;
using MediatR;

namespace Business.CQRS.ContractUnit.Commands.DeleteContract
{
    internal sealed class DeleteContractCommandHandler : ICommandHandler<DeleteContractCommand, Unit>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContractCommandHandler(IContractRepository contractRepository, IUnitOfWork unitOfWork)
        {
            _contractRepository = contractRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteContractCommand request, CancellationToken cancellationToken)
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
