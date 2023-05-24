using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.Exceptions;
using Business.IRepositories;
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
            var customer = await _customerRepository.GetByIdAsync(request.Id, cancellationToken);

            if (customer is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            customer.UpdatedBy = Constants.UserName.System;
            customer.UpdatedOn = DateTime.Now;
            customer.Update(
                request.CustomerFName,
                request.CustomerMName,
                request.CustomerLName,
                request.CustomerCompanyTitle,
                request.CustomerCountry,
                request.CustomerTelNumber,
                request.CustomerMailAddress,
                request.CustomerPostAddress
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
