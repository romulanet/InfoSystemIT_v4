using Business.Abstractions.Messaging;
using Business.Contracts.ContractResponse;
using Domain.Exceptions;
using Domain.Repositories;
using Mapster;

namespace Business.CQRS.ContractUnit.Queries.GetContractById
{
    internal sealed class GetContractByIdQueryHandler : IQueryHandler<GetContractByIdQuery, ContractResponse>
    {
        private readonly IContractRepository _userRepository;

        public GetContractByIdQueryHandler(IContractRepository userRepository) => _userRepository = userRepository;

        public async Task<ContractResponse> Handle(GetContractByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.ContractId, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(request.ContractId);
            }

            return user.Adapt<ContractResponse>();
        }
    }
}