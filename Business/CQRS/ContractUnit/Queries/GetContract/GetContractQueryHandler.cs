using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ContractUnit.Queries.GetContract
{
    internal sealed class GetContractQueryHandler : IQueryHandler<GetContractQuery, List<ContractResponse>>
    {
        private readonly IContractRepository _contractRepository;

        public GetContractQueryHandler(IContractRepository userRepository) => _contractRepository = userRepository;

        public async Task<List<ContractResponse>> Handle(GetContractQuery request, CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.GetAsync(cancellationToken);

            return contract.Adapt<List<ContractResponse>>();
        }
    }
}