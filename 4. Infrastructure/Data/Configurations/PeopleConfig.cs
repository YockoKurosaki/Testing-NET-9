using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class PeopleConfig : IEntityTypeConfiguration<People>
{
	public void Configure(EntityTypeBuilder<People> builder)
	{

		builder.HasKey(s => s.Id);
		builder.Property(s => s.Names).HasMaxLength(200).IsRequired();
		builder.Property(s => s.Lastnames).HasMaxLength(200).IsRequired();
		builder.Property(s => s.PhoneNumber).HasMaxLength(10).IsRequired();
		builder.Property(s => s.Identity).HasMaxLength(15).IsRequired();
		builder.Property(s => s.IdentityTypeId).IsRequired();
		builder.Property(s => s.DeletedOn).IsRequired(false);
		builder.HasQueryFilter(s => s.DeletedOn == null);

		builder.HasOne(s => s.IdentityType)
			.WithMany()
			.HasForeignKey(s => s.IdentityTypeId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasIndex(s => s.IdentityTypeId);
	}
}
