using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class PeopleScheduleRepository(AppDbContext context) : BaseRepository<PeopleSchedule>(context), IPeopleScheduleRepository
{
	public async Task<PeopleSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.Schedule)
			.Include(ps => ps.PeopleProfession).ThenInclude(pp => pp.People)
			.Include(ps => ps.PeopleProfession).ThenInclude(pp => pp.Profession)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}
}
