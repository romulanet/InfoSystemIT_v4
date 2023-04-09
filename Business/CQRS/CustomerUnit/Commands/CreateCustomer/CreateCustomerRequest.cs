namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed record CreateCustomerRequest(
        string CustomerFName,
        string CustomerMName,
        string CustomerLName,
        string CustomerCompanyTitle,
        string CustomerCountry,
        string CustomerTelNumber,
        string CustomerMailAddress,
        string CustomerPostAddress
        );
}
