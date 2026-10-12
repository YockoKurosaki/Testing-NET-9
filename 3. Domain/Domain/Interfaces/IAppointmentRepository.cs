using Domain.Entities;

namespace Domain.Interfaces;

public interface IAppointmentRepository : IBaseRepository<Appointment>
{
	Task<Appointment?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
