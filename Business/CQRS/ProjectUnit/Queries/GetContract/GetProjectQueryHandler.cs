using Business.Abstractions.Messages;
using Business.Contracts.ProjectResponse;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ProjectUnit.Queries.GetProject
{
    internal sealed class GetProjectQueryHandler : IQueryHandler<GetProjectQuery, List<ProjectResponse>>
    {
        private readonly IProjectRepository _contractRepository;

        public GetProjectQueryHandler(IProjectRepository userRepository) => _contractRepository = userRepository;

        public async Task<List<ProjectResponse>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            var project = await _contractRepository.GetAsync(cancellationToken);

            return project.Adapt<List<ProjectResponse>>();
        }
    }
}