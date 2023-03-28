using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;
using Domain.Exceptions;
using Domain.Repositories;
using Mapster;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerById
{
    internal sealed class GetCustomerByIdQueryHandler : IQueryHandler<GetCustomerByIdQuery, CustomerResponse>
    {
        private readonly ICustomerRepository _userRepository;

        public GetCustomerByIdQueryHandler(ICustomerRepository userRepository) => _userRepository = userRepository;

        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.CustomerId, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(request.CustomerId);
            }

            return user.Adapt<CustomerResponse>();
        }
    }
}