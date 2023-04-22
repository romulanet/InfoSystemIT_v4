using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerByIdIncludeContract
{
    internal sealed class GetCustomerByIdQueryIncludeContractHandler : IQueryHandler<GetCustomerByIdIncludeContractQuery, CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerByIdQueryIncludeContractHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<CustomerResponse> Handle(GetCustomerByIdIncludeContractQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdWithContractAsync(request.CustomerId, cancellationToken);

            if (customer is null)
            {
                throw new EntityNotFoundException(request.CustomerId);
            }

            return customer.Adapt<CustomerResponse>();
        }
    }
}