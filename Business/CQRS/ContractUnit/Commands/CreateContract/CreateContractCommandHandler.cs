using Business.Abstractions.Messaging;
using Business.Common.Constants;
using Business.Contracts.ContractResponse;
using Domain.Entities;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ContractUnit.Commands.CreateContract
{
    internal sealed class CreateContractCommandHandler : ICommandHandler<CreateContractCommand, ContractResponse>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateContractCommandHandler(IContractRepository contractRepository, IUnitOfWork unitOfWork)
        {
            _contractRepository = contractRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ContractResponse> Handle(CreateContractCommand request, CancellationToken cancellationToken)
        {
            var contract = new Contract(
                request.ContractTitle,
                request.ContractDescription,
                request.ContractTotalCost
                );
            contract.CreatedOn = DateTime.Now;
            contract.CreatedBy = Constants.UserName.System;

            _contractRepository.Insert(contract);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return contract.Adapt<ContractResponse>();
        }
    }
}