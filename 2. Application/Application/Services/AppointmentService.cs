using Application.Dtos;
using Application.Filters;
using Application.IRepositories;
using Application.Mapper;
using Application.Response;

namespace Application.Services;

public class AppointmentService (IAppointmentRepository repository, AppointmentMapper mapper)
{
	public async Task<PagedResult<SimpleAppointmentDto>> GetSimpleAppointments(AppointmentFilter filters){
		var result = await repository.GetFilteredSimpleAsync(filters);

		if (result is null)
		{
			return PagedResult<SimpleAppointmentDto>.CreateFailure("No se pudieron obtener los datos");
		}

		return mapper.ToSimpleListDto(result);
	}
}
