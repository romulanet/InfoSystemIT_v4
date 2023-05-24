using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using MediatR;

namespace Business.CQRS.ProjectUnit.Commands.DeleteProject
{
    internal sealed class DeleteProjectCommandHandler : ICommandHandler<DeleteProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProjectCommandHandler(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.ProjectId, cancellationToken);

            if (project is null)
            {
                throw new EntityNotFoundException(request.ProjectId);
            }

            _projectRepository.Remove(project);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
