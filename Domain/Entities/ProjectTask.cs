using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProjectTask : CreateUpdateInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string TaskTitle { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? TaskFinishData { get; set; }
        public string TaskStatus { get; set; }
        public TimeOnly? TaskTimeSpent { get; set; }

        //Навигационные свойства
        public Guid? ProjectId { get; set; }
        public Project? Project { get; set; }
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}