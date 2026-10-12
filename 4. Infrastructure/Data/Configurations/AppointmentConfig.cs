using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class AppointmentConfig : IEntityTypeConfiguration<Appointment>
{
	public void Configure(EntityTypeBuilder<Appointment> builder)
	{
		builder.HasKey(s => s.Id);
		builder.Property(s => s.ClientPeopleId).IsRequired();
		builder.Property(s => s.ProfessionalPeopleId).IsRequired();
		builder.Property(s => s.ProcedureId).IsRequired();
		builder.Property(s => s.StatusId).IsRequired();
		builder.Property(s => s.StartAt).IsRequired();
		builder.Property(s => s.EndAt).IsRequired();
		builder.Property(s => s.AppointmentDate).IsRequired();
		builder.Property(s => s.LastUpdated).IsRequired(false);
		builder.Property(s => s.DeletedOn).IsRequired(false);

		builder.HasQueryFilter(s => s.DeletedOn == null);

		builder.HasOne<People>()
				.WithMany()
				.HasForeignKey(s => s.ClientPeopleId)
				.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne<People>()
				.WithMany()
				.HasForeignKey(s => s.ProfessionalPeopleId)
				.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne<Procedure>()
				.WithMany()
				.HasForeignKey(s => s.ProcedureId)
				.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne<Status>()
				.WithMany()
				.HasForeignKey(s => s.StatusId)
				.OnDelete(DeleteBehavior.Restrict);
	}
}
