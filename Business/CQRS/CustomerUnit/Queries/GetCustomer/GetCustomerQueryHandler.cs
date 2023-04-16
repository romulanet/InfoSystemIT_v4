using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomer
{
    internal sealed class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, List<CustomerResponse>>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerQueryHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<List<CustomerResponse>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(cancellationToken);

            return customer.Adapt<List<CustomerResponse>>();
        }
    }
}