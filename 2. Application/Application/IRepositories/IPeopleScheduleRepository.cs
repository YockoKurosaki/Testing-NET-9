using Domain.Entities;

namespace Application.IRepositories;

public interface IPeopleScheduleRepository : IBaseRepository<PeopleSchedule>
{
	Task<PeopleSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
