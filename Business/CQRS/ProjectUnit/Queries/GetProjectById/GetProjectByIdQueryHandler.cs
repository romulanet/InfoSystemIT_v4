using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ProjectUnit.Queries.GetProjectById
{
    internal sealed class GetProjectByIdQueryHandler : IQueryHandler<GetProjectByIdQuery, ProjectResponse>
    {
        private readonly IProjectRepository _userRepository;

        public GetProjectByIdQueryHandler(IProjectRepository userRepository) => _userRepository = userRepository;

        public async Task<ProjectResponse> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.ProjectId, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(request.ProjectId);
            }

            return user.Adapt<ProjectResponse>();
        }
    }
}