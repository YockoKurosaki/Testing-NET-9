using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class PeopleHolidaysRepository(AppDbContext context) : BaseRepository<PeopleHolidays>(context), IPeopleHolidaysRepository
{
	public async Task<PeopleHolidays?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.People)
			.Include(ps => ps.Holidays)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}
}
