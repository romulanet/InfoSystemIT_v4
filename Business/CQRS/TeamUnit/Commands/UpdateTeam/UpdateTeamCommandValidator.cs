using FluentValidation;

namespace Business.CQRS.TeamUnit.Commands.UpdateTeam
{
    public sealed class UpdateTeamCommandValidator : AbstractValidator<UpdateTeamCommand>
    {
        public UpdateTeamCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.TeamTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.TeamDescription).NotEmpty().MaximumLength(500);
        }
    }
}
