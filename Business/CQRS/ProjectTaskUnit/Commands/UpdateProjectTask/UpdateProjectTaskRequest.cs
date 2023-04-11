namespace Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask
{
    public sealed record UpdateProjectTaskRequest(
        string TaskTitle,
        string TaskDescription,
        DateTime TaskFinishData,
        string TaskStatus,
        string TaskTimeSpent
        );
}
