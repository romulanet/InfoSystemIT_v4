using FluentValidation;

namespace Business.CQRS.CustomerUnit.Commands.CreateCustomer
{
    public sealed class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.CustomerFName).NotEmpty().MaximumLength(25);

            RuleFor(x => x.CustomerLName).NotEmpty().MaximumLength(25);
        }
    }
}