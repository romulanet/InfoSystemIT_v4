using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProjectTask : CreateUpdateInfo
    {
        public ProjectTask(string title, string description, DateTime finishData, string status, string timeSpent)
          : this()
        {
            TaskTitle = title;
            TaskDescription = description;
            TaskFinishData = finishData;
            TaskStatus = status;
            TaskTimeSpent = timeSpent;

        }
        public ProjectTask()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string? TaskTitle { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? TaskFinishData { get; set; }
        public string? TaskStatus { get; set; }
        public string? TaskTimeSpent { get; set; }

        //Навигационные свойства
        public Guid? ProjectId { get; set; }
        public Project? Project { get; set; }
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public void Update(string title, string description, DateTime finishData, string status, string timeSpent)
          => (TaskTitle, TaskDescription, TaskFinishData, TaskStatus, TaskTimeSpent)
          = (title, description, finishData, status, timeSpent);

    }
}