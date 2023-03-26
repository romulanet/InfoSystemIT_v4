using Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contract : CreateUpdateInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string ContractTitle { get; set; }
        public string? ContractDescription { get; set; }
        public int? ContractTotalCost { get; set; }

        //Навигационные свойства
        public Guid? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Project>? Projects { get; set; }


    }
}