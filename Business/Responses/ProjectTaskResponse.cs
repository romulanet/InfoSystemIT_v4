using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public sealed record ProjectTaskResponse(
        Guid Id,
        string TaskTitle,
        string TaskDescription,
        DateTime TaskFinishData,
        string TaskStatus,
        string TaskTimeSpent,
        string CreatedBy,
        DateTime CreatedOn,
        string UpdatedBy,
        DateTime UpdatedOn
        );
}
