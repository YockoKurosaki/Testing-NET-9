using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
{
	public void Configure(EntityTypeBuilder<Schedule> builder)
	{

		builder.HasKey(s => s.Id);

		builder.Property(s => s.StartTime).IsRequired();

		builder.Property(s => s.EndTime).IsRequired();

		builder.Property(s => s.DeletedOn).IsRequired(false);

		builder.Property(s => s.Description).HasMaxLength(500).IsRequired(false);

		builder.HasQueryFilter(s => s.DeletedOn == null);
	}
}
