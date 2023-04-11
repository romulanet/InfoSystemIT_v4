using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerById
{
    public sealed record GetCustomerByIdQuery(Guid CustomerId) : IQuery<CustomerResponse>;
}
