namespace Business.Responses
{
    public sealed record CustomerResponse(
        Guid Id,
        string CustomerFName,
        string CustomerMName,
        string CustomerLName,
        string CustomerCompanyTitle,
        string CustomerCountry,
        string CustomerTelNumber,
        string CustomerMailAddress,
        string CustomerPostAddress,
        string CreatedBy,
        DateTime CreatedOn,
        string UpdatedBy,
        DateTime UpdatedOn
        );
}
