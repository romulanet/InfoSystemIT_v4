using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeProjectEmployee
{
    public sealed record GetTeamByIdIncludeAllQuery(Guid TaskId) : IQuery<TeamResponse>;
}
