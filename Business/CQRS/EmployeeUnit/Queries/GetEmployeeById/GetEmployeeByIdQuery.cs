using Business.Abstractions.Messages;
using Business.Contracts.EmployeeResponse;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployeeById
{
    public sealed record GetEmployeeByIdQuery(Guid EmployeeId) : IQuery<EmployeeResponse>;
}
