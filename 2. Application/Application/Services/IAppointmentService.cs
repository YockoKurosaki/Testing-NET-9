using Application.Dtos;
using Application.Filters;
using Utils.Response;

namespace Application.Services;

public interface IAppointmentService
{
	Task<PagedResult<AppointmentSimpleDto>> GetSimpleAppointments(AppointmentFilter filters);
}
