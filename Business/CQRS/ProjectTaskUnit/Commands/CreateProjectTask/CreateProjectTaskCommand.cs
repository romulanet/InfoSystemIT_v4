using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask
{
    public sealed record CreateProjectTaskCommand(
        string TaskTitle,
        string TaskDescription,
        DateTime TaskFinishData,
        string TaskStatus,
        string TaskTimeSpent
        ) : ICommand<ProjectTaskResponse>;
}
