namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record UpdateCustomerRequest(
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
