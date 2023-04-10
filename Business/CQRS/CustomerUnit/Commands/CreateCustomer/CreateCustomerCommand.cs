using Business.Abstractions.Messages;
using Business.Contracts.CustomerResponse;

namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed record CreateCustomerCommand(
 string CustomerFName,
        string CustomerMName,
        string CustomerLName,
        string CustomerCompanyTitle,
        string CustomerCountry,
        string CustomerTelNumber,
        string CustomerMailAddress,
        string CustomerPostAddress
        ) : ICommand<CustomerResponse>;
}
