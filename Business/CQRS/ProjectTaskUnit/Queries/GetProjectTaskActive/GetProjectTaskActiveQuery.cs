using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskActive
{
    public sealed record GetProjectTaskActiveQuery() : IQuery<List<ProjectTaskResponse>>;
}
