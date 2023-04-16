using Business.CQRS.TeamUnit.Commands.CreateTeam;
using Business.CQRS.TeamUnit.Commands.DeleteTeam;
using Business.CQRS.TeamUnit.Commands.UpdateTeam;
using Business.CQRS.TeamUnit.Queries.GetTeam;
using Business.CQRS.TeamUnit.Queries.GetTeamById;
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
{   /// <summary>
    /// The users controller.
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public TeamController(ISender sender) => _sender = sender;
        /// <summary>
        /// Gets all of the teams.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of team.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<TeamResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {

            var query = new GetTeamQuery();

            var team = await _sender.Send(query, cancellationToken);

            return Ok(team);
        }

        /// <summary>
        /// Gets the team with the specified identifier, if it exists.
        /// </summary>
        /// <param name="teamId">The team identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The team with the specified identifier, if it exists.</returns>
        [HttpGet("{teamId:guid}")]
        [ProducesResponseType(typeof(TeamResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid teamId, CancellationToken cancellationToken)
        {
            var query = new GetTeamByIdQuery(teamId);

            var team = await _sender.Send(query, cancellationToken);

            return Ok(team);
        }

        /// <summary>
        /// Creates a new team based on the specified request.
        /// </summary>
        /// <param name="request">The create team request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The newly created team.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(TeamResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateTeamRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<CreateTeamCommand>();

            var team = await _sender.Send(command, cancellationToken);

            return CreatedAtAction(nameof(GetById), new { teamId = team.Id }, team);
        }

        /// <summary>
        /// Updates the team with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="teamId">The team identifier.</param>
        /// <param name="request">The update team request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpPut("{teamId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid teamId, [FromBody] UpdateTeamRequest request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UpdateTeamCommand>() with
            {
                Id = teamId,
                TeamTitle = request.TeamTitle,
                TeamDescription = request.TeamDescription
            };

            await _sender.Send(command, cancellationToken);

            return NoContent();
        }

        /// <summary>
        /// Delete the team with the specified identifier based on the specified request, if it exists.
        /// </summary>
        /// <param name="teamId">The team identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>No content.</returns>
        [HttpDelete("{teamId:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid teamId, CancellationToken cancellationToken)
        {
            var command = new DeleteTeamCommand(teamId);

            var team = await _sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}
