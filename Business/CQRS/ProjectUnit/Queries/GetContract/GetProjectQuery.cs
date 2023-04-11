using Business.Abstractions.Messages;
using Business.Contracts.ProjectResponse;

namespace Business.CQRS.ProjectUnit.Queries.GetProject
{
    public sealed record GetProjectQuery() : IQuery<List<ProjectResponse>>;
}
