using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.Responses;
using Domain.Entities;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.ProjectUnit.Commands.CreateProject
{
    internal sealed class CreateProjectCommandHandler : ICommandHandler<CreateProjectCommand, ProjectResponse>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProjectCommandHandler(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProjectResponse> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(
                request.ProjectTitle,
                request.ProjectType,
                request.ProjectDescription,
                request.ProjectStatus,
                request.ProjectTimeSpent,
                request.ProjectFinishData
                );
            project.CreatedOn = DateTime.Now;
            project.CreatedBy = Constants.UserName.System;

            _projectRepository.Insert(project);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return project.Adapt<ProjectResponse>();
        }
    }
}