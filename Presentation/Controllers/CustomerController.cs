﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Business.Contracts.CustomerResponse;
using Business.CQRS.CustomerUnit.Commands.CreateCustomer;
using Business.CQRS.CustomerUnit.Commands.UpdateCustomer;
using Business.CQRS.CustomerUnit.Queries.GetCustomerById;
using Business.CQRS.CustomerUnit.Queries.GetCustomer;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentation.Controllers
{
    /// <summary>
    /// The users controller.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public sealed class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public CustomerController(ISender sender) => _sender = sender;

        ///// <summary>
        ///// Gets all of the users.
        ///// </summary>
        ///// <param name="cancellationToken">The cancellation token.</param>
        ///// <returns>The collection of users.</returns>
        //[HttpGet]
        //[ProducesResponseType(typeof(List<UserResponse>), StatusCodes.Status200OK)]
        //public async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        //{
        //    var query = new GetUsersQuery();

        //    var users = await _sender.Send(query, cancellationToken);

        //    return Ok(users);
        //}

        ///// <summary>
        ///// Gets the user with the specified identifier, if it exists.
        ///// </summary>
        ///// <param name="userId">The user identifier.</param>
        ///// <param name="cancellationToken">The cancellation token.</param>
        ///// <returns>The user with the specified identifier, if it exists.</returns>
        //[HttpGet("{userId:int}")]
        //[ProducesResponseType(typeof(UserResponse), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetUserById(int userId, CancellationToken cancellationToken)
        //{
        //    var query = new GetUserByIdQuery(userId);

        //    var user = await _sender.Send(query, cancellationToken);

        //    return Ok(user);
        //}

        ///// <summary>
        ///// Creates a new user based on the specified request.
        ///// </summary>
        ///// <param name="request">The create user request.</param>
        ///// <param name="cancellationToken">The cancellation token.</param>
        ///// <returns>The newly created user.</returns>
        //[HttpPost]
        //[ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status201Created)]
        //public async Task<IActionResult> CreateUser([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
        //{
        //    var command = request.Adapt<CreateCustomerCommand>();

        //    var user = await _sender.Send(command, cancellationToken);

        //    return CreatedAtAction(nameof(GetCustomerById), new { userId = user.Id }, user);
        //}

        /// <summary>
        /// Updates the customer with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="request">The update customer request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{userId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateUser(Guid customerId, [FromBody] UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateCustomerCommand>() with
            {
                CustomerId = customerId
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
