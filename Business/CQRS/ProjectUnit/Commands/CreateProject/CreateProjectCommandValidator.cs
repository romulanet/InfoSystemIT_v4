using FluentValidation;

namespace Business.CQRS.ProjectUnit.Commands.CreateProject
{
    public sealed class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(x => x.ProjectTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.ProjectDescription).NotEmpty().MaximumLength(500);
        }
    }
}