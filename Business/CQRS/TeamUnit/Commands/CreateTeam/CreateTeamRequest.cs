namespace Business.CQRS.TeamUnit.Commands.CreateTeam
{
    public sealed record CreateTeamRequest(
       string TeamTitle,
       string TeamDescription
        );
}
