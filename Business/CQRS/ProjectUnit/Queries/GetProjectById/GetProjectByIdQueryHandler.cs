using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectById
{
    internal sealed class GetProjectByIdQueryHandler : IQueryHandler<GetProjectByIdQuery, ProjectResponse>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectByIdQueryHandler(IProjectRepository projectRepository) => _projectRepository = projectRepository;

        public async Task<ProjectResponse> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.ProjectId, cancellationToken);

            if (project is null)
            {
                throw new EntityNotFoundException(request.ProjectId);
            }

            return project.Adapt<ProjectResponse>();
        }
    }
}