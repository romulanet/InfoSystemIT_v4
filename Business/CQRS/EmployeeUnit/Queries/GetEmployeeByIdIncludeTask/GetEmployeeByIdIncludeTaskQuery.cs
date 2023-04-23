using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployeeByIdIncludeTask
{
    public sealed record GetEmployeeByIdIncludeTaskQuery(Guid EmployeeId) : IQuery<EmployeeResponse>;
}
