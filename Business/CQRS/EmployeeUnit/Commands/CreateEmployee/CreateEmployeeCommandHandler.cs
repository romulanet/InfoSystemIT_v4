using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.Responses;
using Domain.Entities;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.EmployeeUnit.Commands.CreateEmployee
{
    internal sealed class CreateEmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(
                request.EmployeeFName,
                request.EmployeeMName,
                request.EmployeeLName,
                request.EmployeeJobTitle,
                request.EmployeeTelNumber,
                request.EmployeeMailAddress,
                request.EmployeePostAddress
                );
            employee.CreatedOn = DateTime.Now;
            employee.CreatedBy = Constants.UserName.System;

            _employeeRepository.Insert(employee);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return employee.Adapt<EmployeeResponse>();
        }
    }
}