using FluentValidation;

namespace Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask
{
    public sealed class UpdateProjectTaskCommandValidator : AbstractValidator<UpdateProjectTaskCommand>
    {
        public UpdateProjectTaskCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.TaskTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.TaskDescription).NotEmpty().MaximumLength(500);
        }
    }
}
