using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskById
{
    public sealed record GetProjectTaskByIdQuery(Guid TaskId) : IQuery<ProjectTaskResponse>;
}
