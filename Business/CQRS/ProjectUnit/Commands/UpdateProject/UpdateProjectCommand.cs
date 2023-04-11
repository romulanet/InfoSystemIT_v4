using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ProjectUnit.Commands.UpdateProject
{
    public sealed record UpdateProjectCommand(
        Guid Id,
        string ProjectTitle,
        string ProjectType,
        string ProjectDescription,
        string ProjectStatus,
        string ProjectTimeSpent,
        DateTime ProjectFinishData
        ) : ICommand<Unit>;
}
