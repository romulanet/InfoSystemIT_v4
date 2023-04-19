using Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask;
using Business.CQRS.ProjectTaskUnit.Commands.DeleteProjectTask;
using Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask;
using Business.CQRS.ProjectTaskUnit.Queries.GetProjectTask;
using Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskById;
using Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskActive;
using Business.Responses;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Presentation.Controllers
{    /// <summary>
     /// The users controller.
     /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectTaskController : ControllerBase
    {

        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public ProjectTaskController(ISender sender) => _sender = sender;
        /// <summary>
        /// Gets all of the prjectTasks.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of prjectTask.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProjectTaskResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetProjectTaskQuery();

            var prjectTask = await _sender.Send(query, cancellationToken);

            return Ok(prjectTask);
        }

        /// <summary>
        /// Get all active prjectTasks.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of prjectTask.</returns>
        [HttpGet("active")]
        [ProducesResponseType(typeof(List<ProjectTaskResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetActive(CancellationToken cancellationToken)
        {

            var query = new GetProjectTaskActiveQuery();

            var prjectTask = await _sender.Send(query, cancellationToken);

            return Ok(prjectTask);
        }

        /// <summary>
        /// Gets the prjectTask with the specified identifier, if it exists.
        /// </summary>
        /// <param name="prjectTaskId">The prjectTask identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The prjectTask with the specified identifier, if it exists.</returns>
        [HttpGet("{prjectTaskId:guid}")]
        [ProducesResponseType(typeof(ProjectTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid prjectTaskId, CancellationToken cancellationToken)
        {
            var query = new GetProjectTaskByIdQuery(prjectTaskId);

            var prjectTask = await _sender.Send(query, cancellationToken);

            return Ok(prjectTask);
        }

        /// <summary>
        /// Creates a new prjectTask based on the specified request.
        /// </summary>
        /// <param name="request">The create prjectTask request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created prjectTask.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProjectTaskResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateProjectTaskRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateProjectTaskCommand>();

            var prjectTask = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { prjectTaskId = prjectTask.Id }, prjectTask);
        }

        /// <summary>
        /// Updates the prjectTask with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="prjectTaskId">The prjectTask identifier.</param>
        /// <param name="request">The update prjectTask request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{prjectTaskId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid prjectTaskId, [FromBody] UpdateProjectTaskRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateProjectTaskCommand>() with
            {
                Id = prjectTaskId,
                TaskTitle = request.TaskTitle,
                TaskDescription = request.TaskDescription,
                TaskFinishData = request.TaskFinishData,
                TaskStatus = request.TaskStatus,
                TaskTimeSpent = request.TaskTimeSpent,
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Update status the prjectTask with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="prjectTaskId">The prjectTask identifier.</param>
        /// <param name="request">The update prjectTask request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("updateStatus/{prjectTaskId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateStatus(Guid prjectTaskId, [FromBody] UpdateProjectTaskRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateProjectTaskCommand>() with
            {
                TaskStatus = request.TaskStatus,
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Delete the prjectTask with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="prjectTaskId">The prjectTask identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{prjectTaskId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid prjectTaskId, CancellationToken cancellationToken)
        {
            var command = new DeleteProjectTaskCommand(prjectTaskId);

            var prjectTask = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
