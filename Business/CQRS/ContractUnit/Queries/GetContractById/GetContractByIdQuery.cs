using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ContractUnit.Queries.GetContractById
{
    public sealed record GetContractByIdQuery(Guid ContractId) : IQuery<ContractResponse>;
}
