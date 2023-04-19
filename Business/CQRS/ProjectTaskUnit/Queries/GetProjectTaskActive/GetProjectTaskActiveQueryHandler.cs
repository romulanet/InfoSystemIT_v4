using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskActive
{
    internal sealed class GetProjectTaskActiveQueryHandler : IQueryHandler<GetProjectTaskActiveQuery, List<ProjectTaskResponse>>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;

        public GetProjectTaskActiveQueryHandler(IProjectTaskRepository projectTaskRepository) => _projectTaskRepository = projectTaskRepository;

        public async Task<List<ProjectTaskResponse>> Handle(GetProjectTaskActiveQuery request, CancellationToken cancellationToken)
        {
            var projectTask = await _projectTaskRepository.GetAsyncActive(cancellationToken);

            return projectTask.Adapt<List<ProjectTaskResponse>>();
        }
    }
}
