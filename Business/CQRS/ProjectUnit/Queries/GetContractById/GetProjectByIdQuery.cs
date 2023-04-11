using Business.Abstractions.Messages;
using Business.Contracts.ProjectResponse;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectById
{
    public sealed record GetProjectByIdQuery(Guid ProjectId) : IQuery<ProjectResponse>;
}
