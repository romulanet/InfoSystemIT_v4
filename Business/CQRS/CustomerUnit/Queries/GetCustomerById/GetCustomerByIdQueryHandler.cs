using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerById
{
    internal sealed class GetCustomerByIdHandler : IQueryHandler<GetCustomerByIdQuery, CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerByIdHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId, cancellationToken);

            if (customer is null)
            {
                throw new EntityNotFoundException(request.CustomerId);
            }

            return customer.Adapt<CustomerResponse>();
        }
    }
}