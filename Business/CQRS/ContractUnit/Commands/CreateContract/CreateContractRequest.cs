namespace Business.CQRS.ContractUnit.Commands.CreateContract
{
    public sealed record CreateContractRequest(
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost
        );
}
