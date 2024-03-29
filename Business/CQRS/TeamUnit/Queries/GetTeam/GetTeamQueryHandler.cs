﻿using Business.Abstractions.Messages;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.TeamUnit.Queries.GetTeam
{
    internal sealed class GetTeamQueryHandler : IQueryHandler<GetTeamQuery, List<TeamResponse>>
    {
        private readonly ITeamRepository _teamRepository;

        public GetTeamQueryHandler(ITeamRepository teamRepository) => _teamRepository = teamRepository;

        public async Task<List<TeamResponse>> Handle(GetTeamQuery request, CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetAsync(cancellationToken);

            return team.Adapt<List<TeamResponse>>();
        }
    }
}