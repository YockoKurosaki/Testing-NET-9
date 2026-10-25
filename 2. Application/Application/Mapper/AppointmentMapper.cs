using Application.Dtos;
using Application.Response;
using Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace Application.Mapper;

[Mapper]
public partial class AppointmentMapper
{
	public partial UpdateAppointmentDto ToUpdateDto(Appointment appointment);

	[MapProperty(nameof(Appointment.ClientPeople) + "." + nameof(People.FullName), nameof(SimpleAppointmentDto.ClientName))]
	[MapProperty(nameof(Appointment.ProfessionalPeople) + "." + nameof(People.FullName), nameof(SimpleAppointmentDto.ProfessionalName))]
	[MapProperty(nameof(Appointment.Procedure) + "." + nameof(Procedure.Name), nameof(SimpleAppointmentDto.ProcedureName))]
	[MapProperty(nameof(Appointment.Status) + "." + nameof(Status.Name), nameof(SimpleAppointmentDto.StatusName))]
	public partial SimpleAppointmentDto ToSimpleDto(Appointment appointment);
	public partial PagedResult<SimpleAppointmentDto> ToSimpleListDto(PagedResult<Appointment> appointments);

}
