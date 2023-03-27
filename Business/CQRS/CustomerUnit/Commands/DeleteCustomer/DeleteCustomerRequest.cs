namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed record DeleteCustomerRequest(string FirstName, string LastName);
}
