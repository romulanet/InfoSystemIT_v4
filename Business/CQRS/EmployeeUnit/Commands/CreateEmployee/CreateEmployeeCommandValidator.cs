using FluentValidation;

namespace Business.CQRS.EmployeeUnit.Commands.CreateEmployee
{
    public sealed class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.EmployeeFName).NotEmpty().MaximumLength(25);

            RuleFor(x => x.EmployeeLName).NotEmpty().MaximumLength(25);
        }
    }
}