using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ContractUnit.Queries.GetContractById
{
    internal sealed class GetContractByIdQueryHandler : IQueryHandler<GetContractByIdQuery, ContractResponse>
    {
        private readonly IContractRepository _contractRepository;

        public GetContractByIdQueryHandler(IContractRepository contractRepository) => _contractRepository = contractRepository;

        public async Task<ContractResponse> Handle(GetContractByIdQuery request, CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.GetByIdAsync(request.ContractId, cancellationToken);

            if (contract is null)
            {
                throw new EntityNotFoundException(request.ContractId);
            }

            return contract.Adapt<ContractResponse>();
        }
    }
}