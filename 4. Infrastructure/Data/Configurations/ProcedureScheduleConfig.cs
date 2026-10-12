using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class ProcedureScheduleConfig : IEntityTypeConfiguration<ProcedureSchedule>
{
	public void Configure(EntityTypeBuilder<ProcedureSchedule> builder)
	{

		builder.HasKey(s => s.Id);

		builder.HasOne(s => s.Procedure)
			.WithMany()
			.HasForeignKey(s => s.ProcedureId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(s => s.Schedule)
			.WithMany()
			.HasForeignKey(s => s.ScheduleId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
