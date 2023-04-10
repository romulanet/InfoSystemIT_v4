using Business.Abstractions.Messages;
using Business.Contracts.ContractResponse;

namespace Business.CQRS.ContractUnit.Queries.GetContractById
{
    public sealed record GetContractByIdQuery(Guid ContractId) : IQuery<ContractResponse>;
}
