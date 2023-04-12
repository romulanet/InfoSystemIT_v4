using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.TeamUnit.Commands.UpdateTeam
{
    public sealed record UpdateTeamCommand(
        Guid Id,
       string TeamTitle,
       string TeamDescription
        ) : ICommand<Unit>;
}
