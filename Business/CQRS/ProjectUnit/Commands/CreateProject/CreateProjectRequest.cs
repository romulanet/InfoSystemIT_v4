namespace Business.CQRS.ProjectUnit.Commands.CreateProject
{
    public sealed record CreateProjectRequest(
        string ProjectTitle,
        string ProjectType,
        string ProjectDescription,
        string ProjectStatus,
        string ProjectTimeSpent,
        DateTime ProjectFinishData
        );
}
