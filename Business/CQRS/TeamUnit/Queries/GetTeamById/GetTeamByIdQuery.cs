using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Queries.GetTeamById
{
    public sealed record GetTeamByIdQuery(Guid TaskId) : IQuery<TeamResponse>;
}
