﻿using Business.Abstractions.Messaging;
using Business.Contracts.ContractResponse;

namespace Business.CQRS.ContractUnit.Commands.CreateContract
{
    public sealed record CreateContractCommand(
        string ContractTitle,
        string ContractDescription,
        string ContractTotalCost
        ) : ICommand<ContractResponse>;
}
