using Business.Common.Constants;
using Business.Contracts.ProjectResponse;
using Business.CQRS.ProjectUnit.Commands.CreateProject;
using Business.CQRS.ProjectUnit.Commands.UpdateProject;
using Business.CQRS.ProjectUnit.Commands.DeleteProject;
using Business.CQRS.ProjectUnit.Queries.GetProject;
using Business.CQRS.ProjectUnit.Queries.GetProjectById;
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
    public class ProjectController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public ProjectController(ISender sender) => _sender = sender;
        /// <summary>
        /// Gets all of the projects.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of project.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProjectResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetProjectQuery();

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
        [ProducesResponseType(typeof(ProjectResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid projectId, CancellationToken cancellationToken)
        {
            var query = new GetProjectByIdQuery(projectId);

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
        [ProducesResponseType(typeof(ProjectResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateProjectRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateProjectCommand>();

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
        public async Task<IActionResult> Update(Guid projectId, [FromBody] UpdateProjectRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateProjectCommand>() with
            {
                Id = projectId,
                ProjectTitle = request.ProjectTitle,
                ProjectType = request.ProjectType,
                ProjectDescription = request.ProjectDescription,
                ProjectStatus = request.ProjectStatus,
                ProjectTimeSpent = request.ProjectTimeSpent,
                ProjectFinishData = request.ProjectFinishData
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
            var command = new DeleteProjectCommand(projectId);

            var project = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
