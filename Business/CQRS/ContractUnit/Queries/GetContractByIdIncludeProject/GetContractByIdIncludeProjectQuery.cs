using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ContractUnit.Queries.GetContractByIdIncludeProject
{
    public sealed record GetContractByIdIncludeProjectQuery(Guid ContractId) : IQuery<ContractResponse>;
}
