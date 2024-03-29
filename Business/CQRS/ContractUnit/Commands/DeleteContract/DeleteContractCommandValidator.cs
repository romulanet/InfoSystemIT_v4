﻿using FluentValidation;

namespace Business.CQRS.ContractUnit.Commands.DeleteContract
{
    public sealed class DeleteProjectCommandValidator : AbstractValidator<DeleteProjectCommand>
    {
        public DeleteProjectCommandValidator()
        {
            RuleFor(x => x.ContractId).NotEmpty();
        }
    }
}
