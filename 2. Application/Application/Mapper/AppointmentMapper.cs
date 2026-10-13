using Application.Dtos;
using Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace Application.Mapper;

[Mapper]
public partial class AppointmentMapper
{
	public partial UpdateAppointmentDto ToEntity(Appointment appointment);
}
