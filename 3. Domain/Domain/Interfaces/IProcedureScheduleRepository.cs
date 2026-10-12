using Domain.Entities;

namespace Domain.Interfaces;

public interface IProcedureScheduleRepository : IBaseRepository<ProcedureSchedule>
{
	Task<ProcedureSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
