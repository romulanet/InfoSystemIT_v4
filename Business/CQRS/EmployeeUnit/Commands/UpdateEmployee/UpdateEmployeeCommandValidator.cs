using FluentValidation;

namespace Business.CQRS.EmployeeUnit.Commands.UpdateEmployee
{
    public sealed class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.EmployeeFName).NotEmpty().MaximumLength(25);

            RuleFor(x => x.EmployeeLName).NotEmpty().MaximumLength(25);
        }
    }
}
