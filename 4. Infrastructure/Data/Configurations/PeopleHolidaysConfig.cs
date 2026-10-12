using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class PeopleHolidaysConfig : IEntityTypeConfiguration<PeopleHolidays>
{
	public void Configure(EntityTypeBuilder<PeopleHolidays> builder)
	{

		builder.HasKey(s => s.Id);

		builder.HasOne(s => s.People)
			.WithMany()
			.HasForeignKey(s => s.PeopleId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(s => s.Holidays)
			.WithMany()
			.HasForeignKey(s => s.HolidaysId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
