namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record UpdateCustomerRequest(string FirstName, string LastName);
}
