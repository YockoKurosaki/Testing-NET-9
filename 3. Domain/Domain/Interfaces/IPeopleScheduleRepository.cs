using Domain.Entities;

namespace Domain.Interfaces;

public interface IPeopleScheduleRepository : IBaseRepository<PeopleSchedule>
{
	Task<PeopleSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
