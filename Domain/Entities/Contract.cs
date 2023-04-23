using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contract : CreateUpdateInfo
    {
        public Contract(string title, string description, string totalCost)
           : this()
        {
            ContractTitle = title;
            ContractDescription = description;
            ContractTotalCost = totalCost;
        }

        public Contract()
        {
        }
        [Key]
        public Guid Id { get; set; }
        public string ContractTitle { get; set; } = string.Empty;
        public string ContractDescription { get; set; } = string.Empty;
        public string ContractTotalCost { get; set; } = string.Empty;

        //Навигационные свойства
        public Guid? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Project>? Projects { get; set; }

        public void Update(string title, string description, string totalCost)
           => (ContractTitle, ContractDescription, ContractTotalCost)
           = (title, description, totalCost);

    }
}