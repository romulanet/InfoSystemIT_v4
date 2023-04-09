using Business.Abstractions.Messaging;
using Domain.Exceptions;
using Domain.Repositories;
using MediatR;
using Business.Common.Constants;

namespace Business.CQRS.ContractUnit.Commands.UpdateContract
{
    internal sealed class UpdateContractCommandHandler : ICommandHandler<UpdateContractCommand, Unit>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateContractCommandHandler(IContractRepository contractRepository, IUnitOfWork unitOfWork)
        {
            _contractRepository = contractRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateContractCommand request, CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.GetByIdAsync(request.Id, cancellationToken);

            if (contract is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            contract.UpdatedBy = Constants.UserName.System;
            contract.UpdatedOn = DateTime.Now;
            contract.Update(
                request.ContractTitle,
                request.ContractDescription,
                request.ContractTotalCost
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
