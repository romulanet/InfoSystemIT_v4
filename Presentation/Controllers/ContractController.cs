using Business.CQRS.ContractUnit.Commands.CreateContract;
using Business.CQRS.ContractUnit.Commands.DeleteContract;
using Business.CQRS.ContractUnit.Commands.UpdateContract;
using Business.CQRS.ContractUnit.Queries.GetContract;
using Business.CQRS.ContractUnit.Queries.GetContractById;
using Business.CQRS.ContractUnit.Queries.GetContractByIdIncludeProject;
using Business.CQRS.ProjectUnit.Queries.GetProjectByIdIncludeTask;
using Business.Responses;
using Domain.Entities;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    /// <summary>
    /// The users controller.
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ContractController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public ContractController(ISender sender) => _sender = sender;

        /// <summary>
        /// Gets all of the contracts.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of contract.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ContractResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetContractQuery();

            var contract = await _sender.Send(query, cancellationToken);

            return Ok(contract);
        }

        /// <summary>
        /// Gets the contract with the specified identifier, if it exists.
        /// </summary>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The contract with the specified identifier, if it exists.</returns>
        [HttpGet("{contractId:guid}")]
        [ProducesResponseType(typeof(ContractResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid contractId, CancellationToken cancellationToken)
        {
            var query = new GetContractByIdQuery(contractId);

            var contract = await _sender.Send(query, cancellationToken);

            return Ok(contract);
        }

        /// <summary>
        /// Gets the contract with the specified identifier include projects, if it exists.
        /// </summary>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The contract with the specified identifier, if it exists.</returns>
        [HttpGet("{contractId:guid}/Project")]
        [ProducesResponseType(typeof(ContractResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByIdIncludeProject(Guid contractId, CancellationToken cancellationToken)
        {
            var query = new GetContractByIdIncludeProjectQuery(contractId);

            var contract = await _sender.Send(query, cancellationToken);

            return Ok(contract);
        }

        /// <summary>
        /// Creates a new contract based on the specified request.
        /// </summary>
        /// <param name="request">The create contract request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created contract.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ContractResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateContractRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateContractCommand>();

            var contract = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { contractId = contract.Id }, contract);
        }

        /// <summary>
        /// Updates the contract with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="request">The update contract request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{contractId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid contractId, [FromBody] UpdateContractRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateContractCommand>() with
            {
                Id = contractId,
                ContractTitle = request.ContractTitle,
                ContractDescription = request.ContractDescription,
                ContractTotalCost = request.ContractTotalCost,
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Delete the contract with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{contractId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid contractId, CancellationToken cancellationToken)
        {
            var query = new GetContractByIdIncludeProjectQuery(contractId);
            var contract = await _sender.Send(query, cancellationToken);
            if (contract.Projects.Count() > 0)
            {
                return BadRequest("У договора есть не закрытые проекты");
            }

            var command = new DeleteProjectCommand(contractId);
            var deleteContract = await _sender.Send(command, cancellationToken);
            return NoContent();
        }
    }
}
