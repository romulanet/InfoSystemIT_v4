using FluentValidation;

namespace Business.CQRS.CustomerUnit.Commands.DeleteCustomer
{
    public sealed class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            //RuleFor(x => x.CustomerId).NotEqual(Guid.Empty);
        }
    }
}
