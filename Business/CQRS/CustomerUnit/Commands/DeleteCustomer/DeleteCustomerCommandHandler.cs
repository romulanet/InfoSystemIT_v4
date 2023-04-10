﻿using Business.Abstractions.Messaging;
using Business.Exceptions;
using Domain.IRepositories;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.DeleteCustomer
{
    internal sealed class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand, Unit>
    {
        private readonly IContractRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCustomerCommandHandler(IContractRepository customerRepository, IUnitOfWork unitOfWork)
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
