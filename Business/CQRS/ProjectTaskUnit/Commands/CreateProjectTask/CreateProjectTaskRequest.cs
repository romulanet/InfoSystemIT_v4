namespace Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask
{
    public sealed record CreateProjectTaskRequest(
        string TaskTitle,
        string TaskDescription,
        DateTime TaskFinishData,
        string TaskStatus,
        string TaskTimeSpent
        );
}
