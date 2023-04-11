using FluentValidation;

namespace Business.CQRS.ProjectTaskUnit.Commands.DeleteProjectTask
{
    public sealed class DeleteProjectTaskCommandValidator : AbstractValidator<DeleteProjectTaskCommand>
    {
        public DeleteProjectTaskCommandValidator()
        {
            RuleFor(x => x.TaskId).NotEmpty();
        }
    }
}
