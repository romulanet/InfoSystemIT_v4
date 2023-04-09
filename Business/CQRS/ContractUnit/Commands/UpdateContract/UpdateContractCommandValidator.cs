using FluentValidation;

namespace Business.CQRS.ContractUnit.Commands.UpdateContract
{
    public sealed class UpdateContractCommandValidator : AbstractValidator<UpdateContractCommand>
    {
        public UpdateContractCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.ContractTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.ContractDescription).NotEmpty().MaximumLength(500);
        }
    }
}
