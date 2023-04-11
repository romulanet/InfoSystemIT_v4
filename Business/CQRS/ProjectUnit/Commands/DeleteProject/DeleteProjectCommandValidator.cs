using FluentValidation;

namespace Business.CQRS.ProjectUnit.Commands.DeleteProject
{
    public sealed class DeleteProjectCommandValidator : AbstractValidator<DeleteProjectCommand>
    {
        public DeleteProjectCommandValidator()
        {
            RuleFor(x => x.ProjectId).NotEmpty();
        }
    }
}
