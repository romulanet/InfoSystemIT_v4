using Business.Abstractions.Messages;
using Business.Responses;

namespace Business.CQRS.ProjectUnit.Queries.GetProject
{
    public sealed record GetProjectQuery() : IQuery<List<ProjectResponse>>;
}
