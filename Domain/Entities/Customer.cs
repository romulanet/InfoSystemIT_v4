using Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Customer : CreateUpdateInfo
    {
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

        //Доступ
        [NotMapped]
        public Guid UserId { get; set; }

        //public IList<User> Users { get; set; }
    }
}