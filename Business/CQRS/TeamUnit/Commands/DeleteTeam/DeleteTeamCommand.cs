using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.TeamUnit.Commands.DeleteTeam
{
    public sealed record DeleteTeamCommand(Guid TeamId) : ICommand<Unit>;
}
