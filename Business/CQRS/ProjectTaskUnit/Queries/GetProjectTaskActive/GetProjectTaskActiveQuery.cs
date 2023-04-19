using Business.Abstractions.Messages;
using Business.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CQRS.ProjectTaskUnit.Queries.GetProjectTaskActive
{
    public sealed record GetProjectTaskActiveQuery() : IQuery<List<ProjectTaskResponse>>;
}
