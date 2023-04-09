using Business.Abstractions.Messaging;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record UpdateCustomerCommand(Guid Id, string CustomerFName, string CustomerLName) : ICommand<Unit>;
}
