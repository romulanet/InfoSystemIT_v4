using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ContractUnit.Queries.GetContract
{
    public sealed record GetContractQuery() : IQuery<List<ContractResponse>>;
}
