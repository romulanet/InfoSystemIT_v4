using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;

namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed record CreateCustomerCommand(string FirstName, string LastName) : ICommand<CustomerResponse>;
}
