using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public sealed record ProjectResponse(
        Guid Id,
        string ProjectTitle,
        string ProjectType,
        string ProjectDescription,
        string ProjectStatus,
        string ProjectTimeSpent,
        DateTime ProjectFinishData,
        string CreatedBy,
        DateTime CreatedOn,
        string UpdatedBy,
        DateTime UpdatedOn
        );
}
