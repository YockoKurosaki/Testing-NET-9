using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class ProfessionConfig : IEntityTypeConfiguration<Profession>
{
	public void Configure(EntityTypeBuilder<Profession> builder)
	{

		builder.HasKey(s => s.Id);

		builder.Property(s => s.Name).HasMaxLength(100).IsRequired();

		builder.Property(s => s.Description).HasMaxLength(500).IsRequired(false);

		builder.Property(s => s.DeletedOn).IsRequired(false);

		builder.HasQueryFilter(s => s.DeletedOn == null);
	}
}
