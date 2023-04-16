using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Employee : CreateUpdateInfo
    {

        public Employee(string firstName, string midname, string lastName, string jobTitle, string telNumber, string mailAdress, string postAddress)
           : this()
        {
            EmployeeFName = firstName;
            EmployeeMName = midname;
            EmployeeLName = lastName;
            EmployeeJobTitle = jobTitle;
            EmployeeTelNumber = telNumber;
            EmployeeMailAddress = mailAdress;
            EmployeePostAddress = postAddress;
        }
        public Employee()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string? EmployeeFName { get; set; }
        public string? EmployeeMName { get; set; }
        public string? EmployeeLName { get; set; }
        public string? EmployeeJobTitle { get; set; }
        public string? EmployeeTelNumber { get; set; }
        public string? EmployeeMailAddress { get; set; }
        public string? EmployeePostAddress { get; set; }

        //Навигационные свойства

        public IList<ProjectTask>? ProjectTasks { get; set; }
        public IList<Team>? Teams { get; set; }

        public void Update(string firstName, string middlename, string lastName, string jobTitle, string telnumber, string mailAdress, string postAdress)
           => (EmployeeFName, EmployeeMName, EmployeeLName, EmployeeJobTitle, EmployeeTelNumber, EmployeeMailAddress, EmployeePostAddress)
           = (firstName, middlename, lastName, jobTitle, telnumber, mailAdress, postAdress);


    }
}