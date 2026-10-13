using Domain.Entities;

namespace Application.IRepositories;

public interface IProcedureScheduleRepository : IBaseRepository<ProcedureSchedule>
{
	Task<ProcedureSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
