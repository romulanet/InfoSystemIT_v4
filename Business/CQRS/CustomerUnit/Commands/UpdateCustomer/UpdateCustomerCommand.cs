using Business.Abstractions.Messaging;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record UpdateCustomerCommand(Guid CustomerId, string FirstName, string LastName) : ICommand<Unit>;
}
