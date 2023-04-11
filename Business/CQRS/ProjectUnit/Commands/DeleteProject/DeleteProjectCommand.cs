using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ProjectUnit.Commands.DeleteProject
{
    public sealed record DeleteProjectCommand(Guid ProjectId) : ICommand<Unit>;
}
