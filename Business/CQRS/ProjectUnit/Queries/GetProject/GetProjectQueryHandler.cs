using Business.Abstractions.Messages;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ProjectUnit.Queries.GetProject
{
    internal sealed class GetProjectQueryHandler : IQueryHandler<GetProjectQuery, List<ProjectResponse>>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectQueryHandler(IProjectRepository projectRepository) => _projectRepository = projectRepository;

        public async Task<List<ProjectResponse>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetAsync(cancellationToken);

            return project.Adapt<List<ProjectResponse>>();
        }
    }
}