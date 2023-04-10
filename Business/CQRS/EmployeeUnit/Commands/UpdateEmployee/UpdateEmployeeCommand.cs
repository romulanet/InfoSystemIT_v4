using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.EmployeeUnit.Commands.UpdateEmployee
{
    public sealed record UpdateEmployeeCommand(
        Guid Id,
        string EmployeeFName,
        string EmployeeMName,
        string EmployeeLName,
        string EmployeeJobTitle,
        string EmployeeTelNumber,
        string EmployeeMailAddress,
        string EmployeePostAddress
        ) : ICommand<Unit>;
}
