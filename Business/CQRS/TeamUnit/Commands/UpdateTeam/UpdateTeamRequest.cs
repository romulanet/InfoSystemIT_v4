namespace Business.CQRS.TeamUnit.Commands.UpdateTeam
{
    public sealed record UpdateTeamRequest(
       string TeamTitle,
       string TeamDescription
        );
}
