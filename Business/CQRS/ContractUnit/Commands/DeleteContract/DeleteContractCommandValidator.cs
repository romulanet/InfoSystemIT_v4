using FluentValidation;

namespace Business.CQRS.ContractUnit.Commands.DeleteContract
{
    public sealed class DeleteContractCommandValidator : AbstractValidator<DeleteContractCommand>
    {
        public DeleteContractCommandValidator()
        {
            RuleFor(x => x.ContractId).NotEmpty();
        }
    }
}
