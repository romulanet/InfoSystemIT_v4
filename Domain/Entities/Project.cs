using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Project : CreateUpdateInfo
    {
        [Key]
        public Guid Id { get; set; }

        public string ProjectTitle { get; set; }
        public string ProjectType { get; set; }
        public string? ProjectDescription { get; set; }
        public string ProjectStatus { get; set; }
        public TimeOnly? ProjectTimeSpent { get; set; }
        public DateTime? ProjectFinishData { get; set; }

        //Навигационные свойства
        public Guid? ContractId { get; set; }
        public Contract? Contract { get; set; }
        public Guid? TeamId { get; set; }
        public Team? Team { get; set; }
        public ICollection<ProjectTask>? ProjectTasks { get; set; }

    }
}