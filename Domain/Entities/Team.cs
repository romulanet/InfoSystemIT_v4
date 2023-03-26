using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Team : CreateUpdateInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string TeamTitle { get; set; }
        public string? TeamDescription { get; set; }

        public int? EmployeeId { get; set; }

        public ICollection<Project>? Projects { get; set; }
        public ICollection<Employee>? Employees { get; set; }

    }
}