using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.IRepositories;
using Business.Responses;
using Domain.Entities;
using Mapster;

namespace Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask
{
    internal sealed class CreateProjectTaskCommandHandler : ICommandHandler<CreateProjectTaskCommand, ProjectTaskResponse>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProjectTaskCommandHandler(IProjectTaskRepository projectTaskRepository, IUnitOfWork unitOfWork)
        {
            _projectTaskRepository = projectTaskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProjectTaskResponse> Handle(CreateProjectTaskCommand request, CancellationToken cancellationToken)
        {
            var projectTask = new ProjectTask(
                request.TaskTitle,
                request.TaskDescription,
                request.TaskFinishData,
                request.TaskStatus,
                request.TaskTimeSpent
                );
            projectTask.CreatedOn = DateTime.Now;
            projectTask.CreatedBy = Constants.UserName.System;

            _projectTaskRepository.Insert(projectTask);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return projectTask.Adapt<ProjectTaskResponse>();
        }
    }
}