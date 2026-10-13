using Application.Filters;
using Domain.Entities;
using Utils.Response;

namespace Application.IRepositories;

public interface IAppointmentRepository : IBaseRepository<Appointment>
{
	Task<Appointment?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
	Task<PagedResult<Appointment>?> GetFilteredSimpleAsync(AppointmentFilter filter, CancellationToken cancellationToken = default);
}
