using Business.Exceptions;
using MediatR;
using Business.Common.Constants;
using Domain.IRepositories;
using Business.Abstractions.Messages;
using static Business.Common.Constants.Constants;

namespace Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask
{
    internal sealed class UpdateProjectTaskCommandHandler : ICommandHandler<UpdateProjectTaskCommand, Unit>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProjectTaskCommandHandler(IProjectTaskRepository projectTaskRepository, IUnitOfWork unitOfWork)
        {
            _projectTaskRepository = projectTaskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProjectTaskCommand request, CancellationToken cancellationToken)
        {
            var projectTask = await _projectTaskRepository.GetByIdAsync(request.Id, cancellationToken);

            if (projectTask is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            projectTask.UpdatedBy = Constants.UserName.System;
            projectTask.UpdatedOn = DateTime.Now;
            projectTask.Update(
                request.TaskTitle,
                request.TaskDescription,
                request.TaskFinishData,
                request.TaskStatus,
                request.TaskTimeSpent
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
