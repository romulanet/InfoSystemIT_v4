﻿using Business.Abstractions.Messages;
using MediatR;

namespace Business.CQRS.ContractUnit.Commands.UpdateContract
{
    public sealed record UpdateContractCommand(
        Guid Id,
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost
        ) : ICommand<Unit>;
}
