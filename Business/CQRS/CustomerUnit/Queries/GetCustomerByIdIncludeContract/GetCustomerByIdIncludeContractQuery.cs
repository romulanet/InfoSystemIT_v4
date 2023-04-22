using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomerByIdIncludeContract
{
    public sealed record GetCustomerByIdIncludeContractQuery(Guid CustomerId) : IQuery<CustomerResponse>;
}
