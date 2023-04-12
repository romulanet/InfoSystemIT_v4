using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Queries.GetTeam
{
    public sealed record GetTeamQuery() : IQuery<List<TeamResponse>>;
}
