using System.Threading;
using System.Threading.Tasks;
using Business.Abstractions.Messaging;
using Domain.Exceptions;
using Domain.Repositories;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    internal sealed class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId, cancellationToken);

            if (customer is null)
            {
                throw new EntityNotFoundException(request.CustomerId);
            }

            customer.Update(request.FirstName, request.LastName);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
