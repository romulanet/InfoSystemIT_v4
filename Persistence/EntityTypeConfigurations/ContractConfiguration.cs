using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(contract => contract.Id);
            builder.HasIndex(contract => contract.Id).IsUnique();
            builder.Property(contract => contract.ContractTitle).HasMaxLength(50);
            builder.Property(contract => contract.ContractDescription).HasMaxLength(500);
        }
    }
}
