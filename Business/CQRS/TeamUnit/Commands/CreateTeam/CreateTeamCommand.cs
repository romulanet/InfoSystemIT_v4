using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.TeamUnit.Commands.CreateTeam
{
    public sealed record CreateTeamCommand(
       string TeamTitle,
       string TeamDescription
        ) : ICommand<TeamResponse>;
}
