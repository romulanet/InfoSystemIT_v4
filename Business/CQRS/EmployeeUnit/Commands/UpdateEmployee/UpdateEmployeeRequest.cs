namespace Business.CQRS.EmployeeUnit.Commands.UpdateEmployee
{
    public sealed record UpdateEmployeeRequest(
        string EmployeeFName,
        string EmployeeMName,
        string EmployeeLName,
        string EmployeeJobTitle,
        string EmployeeTelNumber,
        string EmployeeMailAddress,
        string EmployeePostAddress
        );
}
