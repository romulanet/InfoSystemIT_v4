using FluentValidation;

namespace Business.CQRS.ContractUnit.Commands.CreateContract
{
    public sealed class CreateContractCommandValidator : AbstractValidator<CreateContractCommand>
    {
        public CreateContractCommandValidator()
        {
            RuleFor(x => x.ContractTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.ContractDescription).NotEmpty().MaximumLength(500);
        }
    }
}