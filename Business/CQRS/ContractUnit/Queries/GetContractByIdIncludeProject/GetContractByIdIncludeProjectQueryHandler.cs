using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ContractUnit.Queries.GetContractByIdIncludeProject
{
    internal sealed class GetContractByIdIncludeProjectQueryHandler : IQueryHandler<GetContractByIdIncludeProjectQuery, ContractResponse>
    {
        private readonly IContractRepository _contractRepository;

        public GetContractByIdIncludeProjectQueryHandler(IContractRepository contractRepository) => _contractRepository = contractRepository;

        public async Task<ContractResponse> Handle(GetContractByIdIncludeProjectQuery request, CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.GetByIdWithContractAsync(request.ContractId, cancellationToken);

            if (contract is null)
            {
                throw new EntityNotFoundException(request.ContractId);
            }

            return contract.Adapt<ContractResponse>();
        }
    }
}