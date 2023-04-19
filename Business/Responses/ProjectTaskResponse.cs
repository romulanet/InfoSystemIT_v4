using Domain.Entities;

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
