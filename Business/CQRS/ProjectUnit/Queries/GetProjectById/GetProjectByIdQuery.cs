using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectById
{
    public sealed record GetProjectByIdQuery(Guid ProjectId) : IQuery<ProjectResponse>;
}
