using Business.Abstractions.Messaging;
using MediatR;

namespace Business.CQRS.CustomerUnit.Commands.DeleteCustomer
{
    public sealed record DeleteCustomerCommand(Guid CustomerId) : ICommand<Unit>;
}
