using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Business.Common.Constants;

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
            var customer = new Customer(request.CustomerFName, request.CustomerLName);
            customer.CreatedOn = DateTime.Now;
            customer.CreatedBy = Constants.UserName.System;

            _customerRepository.Insert(customer);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return customer.Adapt<CustomerResponse>();
        }
    }
}