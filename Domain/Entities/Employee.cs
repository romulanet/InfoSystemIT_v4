using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Employee : CreateUpdateInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string EmployeeFName { get; set; }
        public string? EmployeeMName { get; set; }
        public string EmployeeLName { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string? EmployeeTelNumber { get; set; }
        public string? EmployeeMailAddress { get; set; }
        public string? EmployeePostAdress { get; set; }

        //Навигационные свойства

        public IList<ProjectTask>? ProjectTasks { get; set; }
        public IList<Team>? Teams { get; set; }


    }
}