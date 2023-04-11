using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ContractUnit.Commands.CreateContract
{
    public sealed record CreateContractCommand(
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost
        ) : ICommand<ContractResponse>;
}
