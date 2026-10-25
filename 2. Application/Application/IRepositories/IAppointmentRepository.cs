using Application.Filters;
using Application.Response;
using Domain.Entities;

namespace Application.IRepositories;

public interface IAppointmentRepository : IBaseRepository<Appointment>
{
	Task<Appointment?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
	Task<PagedResult<Appointment>?> GetFilteredSimpleAsync(AppointmentFilter filter, CancellationToken cancellationToken = default);
}
