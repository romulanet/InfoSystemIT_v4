using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask
{
    public sealed record UpdateProjectTaskCommand(
        Guid Id,
        string TaskTitle,
        string TaskDescription,
        DateTime TaskFinishData,
        string TaskStatus,
        string TaskTimeSpent
        ) : ICommand<Unit>;
}
