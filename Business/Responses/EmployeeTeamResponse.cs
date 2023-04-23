using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public sealed record EmployeeTeamResponse(
        Guid EmployeeId,
        Guid TeamId,
        Employee Employee,
        Team Team
        );
 
}
