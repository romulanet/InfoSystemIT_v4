using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerById
{
    public sealed record GetCustomerByIdQuery(Guid CustomerId) : IQuery<CustomerResponse>;
}
