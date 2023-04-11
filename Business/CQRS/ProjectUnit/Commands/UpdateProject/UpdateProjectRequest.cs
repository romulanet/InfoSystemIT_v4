namespace Business.CQRS.ProjectUnit.Commands.UpdateProject
{
    public sealed record UpdateProjectRequest(
        string ProjectTitle,
        string ProjectType,
        string ProjectDescription,
        string ProjectStatus,
        string ProjectTimeSpent,
        DateTime ProjectFinishData
        );
}
