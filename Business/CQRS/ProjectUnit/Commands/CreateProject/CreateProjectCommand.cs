using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectUnit.Commands.CreateProject
{
    public sealed record CreateProjectCommand(
        string ProjectTitle,
        string ProjectType,
        string ProjectDescription,
        string ProjectStatus,
        string ProjectTimeSpent,
        DateTime ProjectFinishData
        ) : ICommand<ProjectResponse>;
}
