using Business.Abstractions.Messages;
using Business.Common.Constants;
using Business.Exceptions;
using Business.IRepositories;
using MediatR;

namespace Business.CQRS.ProjectUnit.Commands.UpdateProject
{
    internal sealed class UpdateProjectCommandHandler : ICommandHandler<UpdateProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id, cancellationToken);

            if (project is null)
            {
                throw new EntityNotFoundException(request.Id);
            }

            project.UpdatedBy = Constants.UserName.System;
            project.UpdatedOn = DateTime.Now;
            project.Update(
                request.ProjectTitle,
                request.ProjectType,
                request.ProjectDescription,
                request.ProjectStatus,
                request.ProjectTimeSpent,
                request.ProjectFinishData
                );
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
