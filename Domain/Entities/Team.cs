using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Team : CreateUpdateInfo
    {
        public Team(string title, string description)
          : this()
        {
            TeamTitle = title;
            TeamDescription = description;

        }
        public Team()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string TeamTitle { get; set; } = string.Empty;
        public string TeamDescription { get; set; }= string.Empty;  

        public ICollection<Project>? Projects { get; set; }
        public ICollection<Employee_Team>? Employees_Teams { get; set; }

        public void Update(string title, string description)
           => (TeamTitle, TeamDescription)
           = (title, description);

    }
}