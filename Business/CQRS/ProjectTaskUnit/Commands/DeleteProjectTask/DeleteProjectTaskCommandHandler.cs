using Business.Abstractions.Messages;
using Business.Exceptions;
using Domain.IRepositories;
using MediatR;

namespace Business.CQRS.ProjectTaskUnit.Commands.DeleteProjectTask
{
    internal sealed class DeleteProjectTaskCommandHandler : ICommandHandler<DeleteProjectTaskCommand, Unit>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProjectTaskCommandHandler(IProjectTaskRepository projectRepository, IUnitOfWork unitOfWork)
        {
            _projectTaskRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProjectTaskCommand request, CancellationToken cancellationToken)
        {
            var projectTask = await _projectTaskRepository.GetByIdAsync(request.TaskId, cancellationToken);

            if (projectTask is null)
            {
                throw new EntityNotFoundException(request.TaskId);
            }

            _projectTaskRepository.Remove(projectTask);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
