using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class ProcedureConfig : IEntityTypeConfiguration<Procedure>
{
	public void Configure(EntityTypeBuilder<Procedure> builder)
	{

		builder.HasKey(s => s.Id);

		builder.Property(s => s.Name).HasMaxLength(100).IsRequired();

		builder.Property(s => s.Description).HasMaxLength(500).IsRequired(false);

		builder.Property(s => s.DeletedOn).IsRequired(false);

		builder.HasQueryFilter(s => s.DeletedOn == null);
	}
}
