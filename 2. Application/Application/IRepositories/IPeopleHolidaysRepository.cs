using Domain.Entities;

namespace Application.IRepositories;

public interface IPeopleHolidaysRepository : IBaseRepository<PeopleHolidays>
{
	Task<PeopleHolidays?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
