using Business.CQRS.EmployeeUnit.Commands.CreateEmployee;
using Business.CQRS.EmployeeUnit.Commands.DeleteEmployee;
using Business.CQRS.EmployeeUnit.Commands.UpdateEmployee;
using Business.CQRS.EmployeeUnit.Queries.GetEmployee;
using Business.CQRS.EmployeeUnit.Queries.GetEmployeeById;
using Business.CQRS.EmployeeUnit.Queries.GetEmployeeByIdIncludeTask;
using Business.Responses;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Presentation.Controllers
{    /// <summary>
     /// The users controller.
     /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public sealed class EmployeeController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public EmployeeController(ISender sender) => _sender = sender;
        /// <summary>
        /// Gets all of the employees.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of employee.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<EmployeeResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetEmployeeQuery();

            var employee = await _sender.Send(query, cancellationToken);

            return Ok(employee);
        }

        /// <summary>
        /// Gets the employee with the specified identifier, if it exists.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The employee with the specified identifier, if it exists.</returns>
        [HttpGet("{employeeId:guid}")]
        [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid employeeId, CancellationToken cancellationToken)
        {
            var query = new GetEmployeeByIdQuery(employeeId);

            var employee = await _sender.Send(query, cancellationToken);

            return Ok(employee);
        }

        /// <summary>
        /// Gets the employee with the specified identifier include Task, if it exists.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The employee with the specified identifier, if it exists.</returns>
        [HttpGet("{employeeId:guid}/ProjectTask")]
        [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByIdIncludeTask(Guid employeeId, CancellationToken cancellationToken)
        {
            var query = new GetEmployeeByIdIncludeTaskQuery(employeeId);

            var employee = await _sender.Send(query, cancellationToken);

            return Ok(employee);
        }

        /// <summary>
        /// Creates a new employee based on the specified request.
        /// </summary>
        /// <param name="request">The create employee request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created employee.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateEmployeeCommand>();

            var employee = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { employeeId = employee.Id }, employee);
        }

        /// <summary>
        /// Updates the employee with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="request">The update employee request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{employeeId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid employeeId, [FromBody] UpdateEmployeeRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateEmployeeCommand>() with
            {
                Id = employeeId,
                EmployeeFName = request.EmployeeFName,
                EmployeeMName = request.EmployeeMName,
                EmployeeLName = request.EmployeeLName,
                EmployeeJobTitle = request.EmployeeJobTitle,
                EmployeeTelNumber = request.EmployeeTelNumber,
                EmployeeMailAddress = request.EmployeeMailAddress,
                EmployeePostAddress = request.EmployeePostAddress,
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Delete the employee with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{employeeId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid employeeId, CancellationToken cancellationToken)
        {
            var command = new DeleteEmployeeCommand(employeeId);

            var employee = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
