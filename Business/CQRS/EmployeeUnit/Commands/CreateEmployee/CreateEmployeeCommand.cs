using Business.Abstractions.Messages;
using Business.Contracts.EmployeeResponse;

namespace Business.CQRS.EmployeeUnit.Commands.CreateEmployee
{
    public sealed record CreateEmployeeCommand(
        string EmployeeFName,
        string EmployeeMName,
        string EmployeeLName,
        string EmployeeJobTitle,
        string EmployeeTelNumber,
        string EmployeeMailAddress,
        string EmployeePostAddress
        ) : ICommand<EmployeeResponse>;
}
