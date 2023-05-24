using Business.Abstractions.Messages;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTask
{
    internal sealed class GetProjectTaskQueryHandler : IQueryHandler<GetProjectTaskQuery, List<ProjectTaskResponse>>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;

        public GetProjectTaskQueryHandler(IProjectTaskRepository projectTaskRepository) => _projectTaskRepository = projectTaskRepository;

        public async Task<List<ProjectTaskResponse>> Handle(GetProjectTaskQuery request, CancellationToken cancellationToken)
        {
            var projectTask = await _projectTaskRepository.GetAsync(cancellationToken);

            return projectTask.Adapt<List<ProjectTaskResponse>>();
        }
    }
}