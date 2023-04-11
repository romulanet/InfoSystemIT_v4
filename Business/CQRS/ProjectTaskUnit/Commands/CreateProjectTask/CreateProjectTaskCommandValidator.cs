using FluentValidation;

namespace Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask
{
    public sealed class CreateProjectTaskCommandValidator : AbstractValidator<CreateProjectTaskCommand>
    {
        public CreateProjectTaskCommandValidator()
        {
            RuleFor(x => x.TaskTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.TaskDescription).NotEmpty().MaximumLength(500);
        }
    }
}