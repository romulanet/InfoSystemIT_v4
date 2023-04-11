using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskById
{
    internal sealed class GetProjectTaskByIdQueryHandler : IQueryHandler<GetProjectTaskByIdQuery, ProjectTaskResponse>
    {
        private readonly IProjectTaskRepository _userRepository;

        public GetProjectTaskByIdQueryHandler(IProjectTaskRepository userRepository) => _userRepository = userRepository;

        public async Task<ProjectTaskResponse> Handle(GetProjectTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.TaskId, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            return user.Adapt<ProjectTaskResponse>();
        }
    }
}