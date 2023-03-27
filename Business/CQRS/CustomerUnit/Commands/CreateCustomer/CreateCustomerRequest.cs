namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed record CreateCustomerRequest(string CustomerFName, string CustomerLName);
}
