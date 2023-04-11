using Business.Common.Constants;
using Business.CQRS.ProjectTaskUnit.Commands.CreateProjectTask;
using Business.CQRS.ProjectTaskUnit.Commands.UpdateProjectTask;
using Business.CQRS.ProjectTaskUnit.Commands.DeleteProjectTask;
using Business.CQRS.ProjectTaskUnit.Queries.GetProjectTask;
using Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskById;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Business.Responses;

namespace Presentation.Controllers
{    /// <summary>
     /// The users controller.
     /// </summary>
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
        /// Gets all of the projects.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of project.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProjectTaskResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetProjectTaskQuery();

            var project = await _sender.Send(query, cancellationToken);

            return Ok(project);
        }

        /// <summary>
        /// Gets the project with the specified identifier, if it exists.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The project with the specified identifier, if it exists.</returns>
        [HttpGet("{projectId:guid}")]
        [ProducesResponseType(typeof(ProjectTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid projectId, CancellationToken cancellationToken)
        {
            var query = new GetProjectTaskByIdQuery(projectId);

            var project = await _sender.Send(query, cancellationToken);

            return Ok(project);
        }

        /// <summary>
        /// Creates a new project based on the specified request.
        /// </summary>
        /// <param name="request">The create project request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created project.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProjectTaskResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateProjectTaskRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateProjectTaskCommand>();

            var project = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { projectId = project.Id }, project);
        }

        /// <summary>
        /// Updates the project with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="request">The update project request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{projectId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid projectId, [FromBody] UpdateProjectTaskRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateProjectTaskCommand>() with
            {
                Id = projectId,
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
        /// Delete the project with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{projectId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid projectId, CancellationToken cancellationToken)
        {
            var command = new DeleteProjectTaskCommand(projectId);

            var project = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
