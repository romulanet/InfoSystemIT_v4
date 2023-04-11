namespace Business.Responses
{
    public sealed record ContractResponse(
        Guid Id,
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost,
        string CreatedBy,
        DateTime CreatedOn,
        string UpdatedBy,
        DateTime UpdatedOn
        );
}
