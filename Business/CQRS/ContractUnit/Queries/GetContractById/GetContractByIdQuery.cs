using Business.Abstractions.Messaging;
using Business.Contracts.ContractResponse;

namespace Business.CQRS.ContractUnit.Queries.GetContractById
{
    public sealed record GetContractByIdQuery(Guid ContractId) : IQuery<ContractResponse>;
}
