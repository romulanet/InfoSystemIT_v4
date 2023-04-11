namespace Business.Responses
{
    public sealed record EmployeeResponse(
        Guid Id,
        string EmployeeFName,
        string EmployeeMName,
        string EmployeeLName,
        string EmployeeJobTitle,
        string EmployeeTelNumber,
        string EmployeeMailAddress,
        string EmployeePostAddress,
        string CreatedBy,
        DateTime CreatedOn,
        string UpdatedBy,
        DateTime UpdatedOn
        );
}
