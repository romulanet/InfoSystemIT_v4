using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.DeleteCustomer
{
    internal sealed class DeleteEmployeeCommandHandler : ICommandHandler<DeleteCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteEmployeeCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId, cancellationToken);

            if (customer is null)
            {
                throw new EntityNotFoundException(request.CustomerId);
            }

            _customerRepository.Remove(customer);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
