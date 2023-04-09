namespace Business.CQRS.ContractUnit.Commands.UpdateContract
{
    public sealed record UpdateContractRequest(
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost
        );
}
