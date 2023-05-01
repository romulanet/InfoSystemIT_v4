using Domain.Entities;

namespace Business.Responses
{
    public sealed record EmployeeTeamResponse(
        Guid EmployeeId,
        Guid TeamId,
        Employee Employee,
        Team Team
        );

}
