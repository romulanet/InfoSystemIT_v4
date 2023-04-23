namespace Business.Responses
{
    public sealed record TeamResponse(
       Guid Id,
       string TeamTitle,
       string TeamDescription,
       string CreatedBy,
       DateTime CreatedOn,
       string UpdatedBy,
       DateTime UpdatedOn,
       IEnumerable<ProjectResponse> Projects,
       IEnumerable<EmployeeResponse> Employees
       );
}