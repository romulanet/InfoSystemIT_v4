using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public sealed record TeamResponse(
       Guid Id,
       string TeamTitle,
       string TeamDescription,
       string CreatedBy,
       DateTime CreatedOn,
       string UpdatedBy,
       DateTime UpdatedOn
       );
}