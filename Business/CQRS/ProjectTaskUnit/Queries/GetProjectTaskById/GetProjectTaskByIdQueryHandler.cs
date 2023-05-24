using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskById
{
    internal sealed class GetProjectTaskByIdQueryHandler : IQueryHandler<GetProjectTaskByIdQuery, ProjectTaskResponse>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;

        public GetProjectTaskByIdQueryHandler(IProjectTaskRepository projectTaskRepository) => _projectTaskRepository = projectTaskRepository;

        public async Task<ProjectTaskResponse> Handle(GetProjectTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var projectTask = await _projectTaskRepository.GetByIdAsync(request.TaskId, cancellationToken);

            if (projectTask is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return projectTask.Adapt<ProjectTaskResponse>();
        }
    }
}