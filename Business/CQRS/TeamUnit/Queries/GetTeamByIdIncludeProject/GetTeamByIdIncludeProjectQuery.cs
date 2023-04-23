using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Queries.GetTeamByIdIncludeProject
{
    public sealed record GetTeamByIdIncludeProjectQuery(Guid TaskId) : IQuery<TeamResponse>;
}
