using System.Threading;
using System.Threading.Tasks;
using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;
using Domain.Entities;
using Domain.Repositories;
using Mapster;

namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    internal sealed class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.FirstName, request.LastName);

            _userRepository.Insert(customer);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return customer.Adapt<CustomerResponse>();
        }
    }
}