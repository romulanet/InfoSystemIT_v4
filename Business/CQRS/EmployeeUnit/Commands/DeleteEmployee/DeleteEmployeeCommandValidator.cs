using FluentValidation;

namespace Business.CQRS.EmployeeUnit.Commands.DeleteEmployee
{
    public sealed class DeleteEmployeeCommandValidator : AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeCommandValidator()
        {
            RuleFor(x => x.EmployeeId).NotEmpty();
            //RuleFor(x => x.CustomerId).NotEqual(Guid.Empty);
        }
    }
}
