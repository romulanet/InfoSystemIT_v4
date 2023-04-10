using Business.Abstractions.Messages;
using Business.Contracts.EmployeeResponse;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployee
{
    public sealed record GetEmployeeQuery() : IQuery<List<EmployeeResponse>>;
}
