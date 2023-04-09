using FluentValidation;

namespace Business.CQRS.CustomerUnit.Commands.UpdateCustomer
{
    public sealed class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.CustomerFName).NotEmpty().MaximumLength(25);

            RuleFor(x => x.CustomerLName).NotEmpty().MaximumLength(25);
        }
    }
}
