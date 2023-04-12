using FluentValidation;

namespace Business.CQRS.TeamUnit.Commands.DeleteTeam
{
    public sealed class DeleteTeamCommandValidator : AbstractValidator<DeleteTeamCommand>
    {
        public DeleteTeamCommandValidator()
        {
            RuleFor(x => x.TeamId).NotEmpty();
        }
    }
}
