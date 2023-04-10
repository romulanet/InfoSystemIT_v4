using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Project : CreateUpdateInfo
    {
        public Project(string title, string description,string type, string status,string timeSpent, DateTime finishData)
          : this()
        {
            ProjectTitle = title;
            ProjectType = type;
            ProjectDescription = description;
            ProjectStatus = status;
            ProjectTimeSpent = timeSpent;
            ProjectFinishData = finishData;
        }
        public Project()
        {
        }
        [Key]
        public Guid Id { get; set; }

        public string? ProjectTitle { get; set; }
        public string? ProjectType { get; set; }
        public string? ProjectDescription { get; set; }
        public string ProjectStatus { get; set; }
        public string? ProjectTimeSpent { get; set; }
        public DateTime? ProjectFinishData { get; set; }

        //Навигационные свойства
        public Guid? ContractId { get; set; }
        public Contract? Contract { get; set; }
        public Guid? TeamId { get; set; }
        public Team? Team { get; set; }
        public ICollection<ProjectTask>? ProjectTasks { get; set; }

        public void Update(string title, string type, string description,  string status, string timeSpent, DateTime finishData)
         => (ProjectTitle, ProjectType, ProjectDescription, ProjectStatus, ProjectTimeSpent, ProjectFinishData)
         = (title, type, description, status,  timeSpent, finishData);

    }
}