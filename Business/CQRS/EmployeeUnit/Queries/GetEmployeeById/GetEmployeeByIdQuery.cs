using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployeeById
{
    public sealed record GetEmployeeByIdQuery(Guid EmployeeId) : IQuery<EmployeeResponse>;
}
