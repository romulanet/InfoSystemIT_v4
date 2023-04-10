using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomer
{
    internal sealed class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, List<CustomerResponse>>
    {
        private readonly IContractRepository _customerRepository;

        public GetCustomerQueryHandler(IContractRepository userRepository) => _customerRepository = userRepository;

        public async Task<List<CustomerResponse>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(cancellationToken);

            return customer.Adapt<List<CustomerResponse>>();
        }
    }
}