using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ContractUnit.Commands.DeleteContract
{
    public sealed record DeleteProjectCommand(Guid ContractId) : ICommand<Unit>;
}
