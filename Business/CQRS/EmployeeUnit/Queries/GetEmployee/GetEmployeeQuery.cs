using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployee
{
    public sealed record GetEmployeeQuery() : IQuery<List<EmployeeResponse>>;
}
