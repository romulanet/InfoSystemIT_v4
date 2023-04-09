namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record UpdateCustomerRequest(string CustomerFName, string CustomerLName);
}
