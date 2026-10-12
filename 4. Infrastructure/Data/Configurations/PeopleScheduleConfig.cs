using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class PeopleScheduleConfig : IEntityTypeConfiguration<PeopleSchedule>
{
	public void Configure(EntityTypeBuilder<PeopleSchedule> builder)
	{

		builder.HasKey(s => s.Id);

		builder.HasOne(s => s.PeopleProfession)
			.WithMany()
			.HasForeignKey(s => s.PeopleProfessionId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(s => s.Schedule)
			.WithMany()
			.HasForeignKey(s => s.ScheduleId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasIndex(s => s.ScheduleId);
		builder.HasIndex(s => s.PeopleProfessionId);
	}
}
