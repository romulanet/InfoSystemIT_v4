namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed record CreateCustomerRequest(string FirstName, string LastName);
}
