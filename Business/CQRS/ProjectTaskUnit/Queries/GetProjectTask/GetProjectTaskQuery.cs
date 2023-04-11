using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTask
{
    public sealed record GetProjectTaskQuery() : IQuery<List<ProjectTaskResponse>>;
}
