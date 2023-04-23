using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee_Team
    {
        public Guid? EmployeeId { get; set; }
        public Guid? TeamId { get; set; }

        // Navigation Properties
        public Employee? Employee { get; set; }
        public Team? Team { get; set; }
    }
}
