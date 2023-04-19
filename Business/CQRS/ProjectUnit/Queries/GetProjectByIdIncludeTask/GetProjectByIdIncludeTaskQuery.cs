using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectByIdIncludeTask
{
    public sealed record GetProjectByIdIncludeTaskQuery(Guid ProjectId) : IQuery<ProjectResponse>;
}
