namespace Business.CQRS.EmployeeUnit.Commands.CreateEmployee
{
    public sealed record CreateEmployeeRequest(
        string EmployeeFName,
        string EmployeeMName,
        string EmployeeLName,
        string EmployeeJobTitle,
        string EmployeeTelNumber,
        string EmployeeMailAddress,
        string EmployeePostAddress
        );
}
