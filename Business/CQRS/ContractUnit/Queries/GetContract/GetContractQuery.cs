using Business.Abstractions.Messaging;
using Business.Contracts.ContractResponse;

namespace Business.CQRS.ContractUnit.Queries.GetContract
{
    public sealed record GetContractQuery() : IQuery<List<ContractResponse>>;
}
