using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomer
{
    public sealed record GetCustomerQuery() : IQuery<List<CustomerResponse>>;
}
