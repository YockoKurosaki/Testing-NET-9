using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class PeopleProfessionConfig : IEntityTypeConfiguration<PeopleProfession>
{
	public void Configure(EntityTypeBuilder<PeopleProfession> builder)
	{

		builder.HasKey(s => s.Id);

		builder.HasOne(s => s.People)
			.WithMany()
			.HasForeignKey(s => s.PeopleId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(s => s.Profession)
			.WithMany()
			.HasForeignKey(s => s.ProfessionId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
