using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.EmployeeUnit.Commands.DeleteEmployee
{
    public sealed record DeleteEmployeeCommand(Guid EmployeeId) : ICommand<Unit>;
}
