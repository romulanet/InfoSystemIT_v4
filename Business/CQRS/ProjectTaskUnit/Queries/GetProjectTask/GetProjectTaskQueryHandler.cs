using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTask
{
    internal sealed class GetProjectTaskQueryHandler : IQueryHandler<GetProjectTaskQuery, List<ProjectTaskResponse>>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;

        public GetProjectTaskQueryHandler(IProjectTaskRepository userRepository) => _projectTaskRepository = userRepository;

        public async Task<List<ProjectTaskResponse>> Handle(GetProjectTaskQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectTaskRepository.GetAsync(cancellationToken);

            return project.Adapt<List<ProjectTaskResponse>>();
        }
    }
}