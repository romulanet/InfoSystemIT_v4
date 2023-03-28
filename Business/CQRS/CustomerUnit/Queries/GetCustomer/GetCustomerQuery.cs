﻿using Business.Abstractions.Messaging;
using Business.Contracts.CustomerResponse;

namespace Business.CQRS.CustomerUnit.Queries.GetCustomer
{
    public sealed record GetCustomerQuery() : IQuery<List<CustomerResponse>>;
}
