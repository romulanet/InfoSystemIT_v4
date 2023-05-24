using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectByIdIncludeTask
{
    internal sealed class GetProjectByIdIncludeTaskQueryHandler : IQueryHandler<GetProjectByIdIncludeTaskQuery, ProjectResponse>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectByIdIncludeTaskQueryHandler(IProjectRepository projectRepository) => _projectRepository = projectRepository;

        public async Task<ProjectResponse> Handle(GetProjectByIdIncludeTaskQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdWithTaskAsync(request.ProjectId, cancellationToken);

            if (project is null)
            {
                throw new EntityNotFoundException(request.ProjectId);
            }

            return project.Adapt<ProjectResponse>();
        }
    }
}