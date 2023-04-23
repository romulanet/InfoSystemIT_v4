using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public sealed class Customer : CreateUpdateInfo
    {
        public Customer(string firstName, string midname, string lastName, string companyTitle, string country, string telNumber, string mailAdress, string postAddress)
            : this()
        {
            CustomerFName = firstName;
            CustomerMName = midname;
            CustomerLName = lastName;
            CustomerCompanyTitle = companyTitle;
            CustomerCountry = country;
            CustomerTelNumber = telNumber;
            CustomerMailAddress = mailAdress;
            CustomerPostAddress = postAddress;
        }

        public Customer()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string CustomerFName { get; set; } = string.Empty;
        public string CustomerMName { get; set; } = string.Empty;
        public string CustomerLName { get; set; } = string.Empty;
        public string CustomerCompanyTitle { get; set; } = string.Empty;
        public string CustomerCountry { get; set; } = string.Empty;
        public string CustomerTelNumber { get; set; } = string.Empty;
        public string CustomerMailAddress { get; set; } = string.Empty;
        public string CustomerPostAddress { get; set; } = string.Empty;

        //Навигационные свойства
        public ICollection<Contract>? Contracts { get; set; }

        public void Update(string firstName, string middlename, string lastName, string companyTitle, string country, string telnumber, string mailAdress, string postAdress)
            => (CustomerFName, CustomerMName, CustomerLName, CustomerCompanyTitle, CustomerCountry, CustomerTelNumber, CustomerMailAddress, CustomerPostAddress)
            = (firstName, middlename, lastName, companyTitle, country, telnumber, mailAdress, postAdress);

    }
}