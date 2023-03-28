using Business.Contracts.CustomerResponse;
using Business.CQRS.CustomerUnit.Commands.CreateCustomer;
using Business.CQRS.CustomerUnit.Commands.DeleteCustomer;
using Business.CQRS.CustomerUnit.Commands.UpdateCustomer;
using Business.CQRS.CustomerUnit.Queries.GetCustomer;
using Business.CQRS.CustomerUnit.Queries.GetCustomerById;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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

        /// <summary>
        /// Gets all of the customers.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of customer.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<CustomerResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetCustomerQuery();

            var customer = await _sender.Send(query, cancellationToken);

            return Ok(customer);
        }

        /// <summary>
        /// Gets the customer with the specified identifier, if it exists.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The customer with the specified identifier, if it exists.</returns>
        [HttpGet("{customerId:guid}")]
        [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid customerId, CancellationToken cancellationToken)
        {
            var query = new GetCustomerByIdQuery(customerId);

            var customer = await _sender.Send(query, cancellationToken);

            return Ok(customer);
        }

        /// <summary>
        /// Creates a new customer based on the specified request.
        /// </summary>
        /// <param name="request">The create customer request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created customer.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateCustomerCommand>();

            var customer = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { customerId = customer.Id }, customer);
        }

        /// <summary>
        /// Updates the customer with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="request">The update customer request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{customerId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid customerId, [FromBody] UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateCustomerCommand>() with
            {
                CustomerId = customerId
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Delete the customer with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{customerId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid customerId, CancellationToken cancellationToken)
        {
            var command = new DeleteCustomerCommand(customerId);

            var customer = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
