using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public sealed class Customer : CreateUpdateInfo
    {
        public Customer(string firstName, string lastName)
            : this()
        {
            CustomerFName = firstName;
            CustomerLName = lastName;
        }

        public Customer()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string CustomerFName { get; set; }
        public string? CustomerMName { get; set; }
        public string CustomerLName { get; set; }
        public string? CustomerCompanyTitle { get; set; }
        public string? CustomerCountry { get; set; }
        public string? CustomerTelNumber { get; set; }
        public string? CustomerMailAddress { get; set; }
        public string? CustomerPostAddress { get; set; }

        //Навигационные свойства
        public ICollection<Contract>? Contracts { get; set; }

        public void Update(string firstName, string lastName) => (CustomerFName, CustomerLName) = (firstName, lastName);

    }
}