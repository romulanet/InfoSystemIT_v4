using FluentValidation;

namespace Business.CQRS.TeamUnit.Commands.CreateTeam
{
    public sealed class CreateTeamCommandValidator : AbstractValidator<CreateTeamCommand>
    {
        public CreateTeamCommandValidator()
        {
            RuleFor(x => x.TeamTitle).NotEmpty().MaximumLength(50);

            RuleFor(x => x.TeamDescription).NotEmpty().MaximumLength(500);
        }
    }
}