using Domain.Entities;

namespace Domain.Interfaces;

public interface IPeopleHolidaysRepository : IBaseRepository<PeopleHolidays>
{
	Task<PeopleHolidays?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
