using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ProjectTaskUnit.Commands.DeleteProjectTask
{
    public sealed record DeleteProjectTaskCommand(Guid TaskId) : ICommand<Unit>;
}
