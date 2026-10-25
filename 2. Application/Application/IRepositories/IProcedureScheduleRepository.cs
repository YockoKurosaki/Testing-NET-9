using Domain.Entities;

namespace Application.IRepositories;

public interface IProcedureScheduleRepository : IBaseRepository<ProcedureSchedule>
{
	Task<ProcedureSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
	Task<IEnumerable<ProcedureSchedule>> GetByProcedureIdAsync(int procedureId, CancellationToken cancellationToken = default);
}
