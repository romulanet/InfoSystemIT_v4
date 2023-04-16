using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.Exceptions;
using Domain.IRepositories;
using MediatR;

namespace Business.CQRS.EmployeeUnit.Commands.UpdateEmployee
{
    internal sealed class UpdateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetByIdAsync(request.Id, cancellationToken);

            if (employee is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            employee.UpdatedBy = Constants.UserName.System;
            employee.UpdatedOn = DateTime.Now;
            employee.Update(
                request.EmployeeFName,
                request.EmployeeMName,
                request.EmployeeLName,
                request.EmployeeJobTitle,
                request.EmployeeTelNumber,
                request.EmployeeMailAddress,
                request.EmployeePostAddress
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
