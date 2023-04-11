using FluentValidation;

namespace Business.CQRS.ProjectUnit.Commands.UpdateProject
{
    public sealed class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.ProjectTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.ProjectDescription).NotEmpty().MaximumLength(500);
        }
    }
}
