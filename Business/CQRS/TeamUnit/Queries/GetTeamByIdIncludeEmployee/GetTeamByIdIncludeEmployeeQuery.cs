using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeEmployee
{
    public sealed record GetTeamByIdIncludeEmployeeQuery(Guid TaskId) : IQuery<TeamResponse>;
}
