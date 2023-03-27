using FluentValidation;

namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty();

            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(25);

            RuleFor(x => x.LastName).NotEmpty().MaximumLength(25);
        }
    }
}
