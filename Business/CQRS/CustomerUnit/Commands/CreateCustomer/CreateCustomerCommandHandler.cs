using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.IRepositories;
using Business.Responses;
using Domain.Entities;
using Mapster;

namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    internal sealed class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var employee = new Customer(
                request.CustomerFName,
                request.CustomerMName,
                request.CustomerLName,
                request.CustomerCompanyTitle,
                request.CustomerCountry,
                request.CustomerTelNumber,
                request.CustomerMailAddress,
                request.CustomerPostAddress
                );
            employee.CreatedOn = DateTime.Now;
            employee.CreatedBy = Constants.UserName.System;

            _customerRepository.Insert(employee);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return employee.Adapt<CustomerResponse>();
        }
    }
}